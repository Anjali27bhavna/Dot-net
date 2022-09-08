using ATMApp.Domain.Entities;
using ATMApp.Domain.Enums;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ATMApp
{
    public class ATMApp:IUserLogin,IUserAccountActions,ITransaction
    {
        private List<UserAccounts> userAccountList;
        private UserAccounts selectedAccount;
        private List<transaction> _listofTransactions;
        private const decimal minimumKeptAmount = 500;
        public void IntializeData()
        {
            userAccountList = new List<UserAccounts>
            {
                new UserAccounts{Id=1,FullName="Anjali saini", AccountNumber=123456,CardNumber=321321,CardPin=123123,AccountBalance=50000.00m,IsLocked=false},
                new UserAccounts{Id=1,FullName="Nilesh", AccountNumber=456789,CardNumber=654654,CardPin=456456,AccountBalance=40000.00m,IsLocked=false},
                new UserAccounts{Id=1,FullName="Nikhil", AccountNumber=123555,CardNumber=987987,CardPin=789789,AccountBalance=20000.00m,IsLocked=true},

            };
            _listofTransactions = new List<transaction>();

        }
        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while (isCorrectLogin == false)
            {
                UserAccounts inputAccount = AppScreen.UserLoginForm();

                AppScreen.LoginProgress();
                foreach(UserAccounts account in userAccountList)
                {
                    selectedAccount = account;
                    if(inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if(inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = account;
                            if(selectedAccount.IsLocked || selectedAccount.TotalLogin>3)
                            {
                                //print a lock message
                                AppScreen.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                    if (isCorrectLogin == false)
                    {
                        Utility.PrintMessage("\n Invalid card number or PIN.", false);
                        selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                        if (selectedAccount.IsLocked)
                        {
                            AppScreen.PrintLockScreen();
                        }
                    }
                    Console.Clear();
                }
            }
              
        }

       public void Run()
        {
            AppScreen.Welcome();
            CheckUserCardNumAndPassword();
            AppScreen.WelcomeCustomer(selectedAccount.FullName);
            AppScreen.DisplayAppMenu();
            ProcessMenuoption();
        }
       
        private void ProcessMenuoption()
        {
            switch(Validate.Convert<int>("an option: "))
            {
                case (int)AppMenu.CheckBalance:
                    CheckBalance();
                    break;
                case (int)AppMenu.PlaceDeposit:
                    PlaceDeposit();
                    break;
                case (int)AppMenu.MakeWithdrawal:
                    MakeWithDrawal();
                    break;
                case (int)AppMenu.InternalTransfer:
                    Console.WriteLine("Making internal transfer...");
                    break;
                case (int)AppMenu.ViewTransaction:
                    Console.WriteLine("Viewing transactions...");
                    break;
                case (int)AppMenu.Logout:
                    AppScreen.LogOutProgress();
                    Utility.PrintMessage("You have successfully logged out. Please collect your ATM card.");
                    Run();
                    break;
                default:
                    Utility.PrintMessage("Invalid option", false);
                    break;
            }
        }

        public void CheckBalance()
        {
            Utility.PrintMessage($"Your account balance is: {Utility.FormatAmount(selectedAccount.AccountBalance)}");
        }

        public void PlaceDeposit()
        {
            Console.WriteLine("\nOnly multiples of 500 and 1000 rupees allowed.\n");
            var transaction_amt = Validate.Convert<int>($"amount {AppScreen.cur}");

            //simulate counting
            Console.WriteLine("\nChecking and Counting bank notes.");
            Console.WriteLine("");

            //some gaurd clause
            if(transaction_amt<=0)
            {
                Utility.PrintMessage("Amount needs to be greater than zero. Try again.", false);
                return;
            }
            if(transaction_amt % 500 !=0)
            {
                Utility.PrintMessage($"Enter deposit amount in multiples of 500 or 1000. Try again", false);
                return;
            }
            if(PreviewBankNotesCount(transaction_amt)==false)
            {
                Utility.PrintMessage($"You have cancelled your action.", false);
                return;
            }
            //bind transaction details to transaction object
            InsertTransaction(selectedAccount.Id, TransactionType.Deposit, transaction_amt, "");

            //update account balance
            selectedAccount.AccountBalance += transaction_amt;

            //print success message
            Utility.PrintMessage($"Your deposit of {Utility.FormatAmount(transaction_amt)} was successful", true);

        }

        public void MakeWithDrawal()
        {
            var transaction_amt = 0;
            int selectedAmount = AppScreen.SelectAmount();
            if(selectedAmount==-1)
            {
                selectedAmount = AppScreen.SelectAmount();
            }
            else if(selectedAmount !=0)
            {
                transaction_amt = selectedAmount;
            }
            else
            {
                transaction_amt = Validate.Convert<int>($"amount {AppScreen.cur}");
            }

            //input validation
            if(transaction_amt<=0)
            {
                Utility.PrintMessage("Amount needs to be greater than zero. Try again", false);
                return;
            }
            if(transaction_amt %500!=0)
            {
                Utility.PrintMessage("You can only withdraw in multiples of 500 or 1000. Try again", false);
                return;
            }
            //business logic validations

            if(transaction_amt > selectedAccount.AccountBalance)
            {
                Utility.PrintMessage($"Withdrawal failed. Your balance is too low {Utility.FormatAmount(transaction_amt)}", false);
                return;
            }
            if((selectedAccount.AccountBalance-transaction_amt) < minimumKeptAmount)
            {
                Utility.PrintMessage($"Withdrawal failed. Your account needs to have minimum {Utility.FormatAmount(minimumKeptAmount)}", false);
                return;
            }
            //bind withdrawal details to transaction object
            InsertTransaction(selectedAccount.Id, TransactionType.Withdrawal, -transaction_amt, "");
            //update account balance
            selectedAccount.AccountBalance -= transaction_amt;
            //success message
            Utility.PrintMessage($"You have successfully withdrawn {Utility.FormatAmount(transaction_amt)}", true);


        }
        private bool PreviewBankNotesCount(int amount)
        {
            int thousandNotedCount = amount / 1000;
            int fiveHundredNotesCount = (amount % 1000) / 500;

            Console.WriteLine("\nSummary");
            Console.WriteLine("----------");
            Console.WriteLine($"{AppScreen.cur}1000 X {thousandNotedCount}={1000 * thousandNotedCount}");
            Console.WriteLine($"{AppScreen.cur}500 X {fiveHundredNotesCount}={500 * fiveHundredNotesCount}");
            Console.WriteLine($"Total amount : {Utility.FormatAmount(amount)}\n\n");

            int opt = Validate.Convert<int>("1 to confirm");
            return opt.Equals(1);
        }

        public void InsertTransaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc)
        {
            //create a new transaction object
            var transaction = new transaction()
            {
                TransactionId = Utility.GetTransactionId(),
                UserBankAccountId = _UserBankAccountId,
                TransactionDate = DateTime.Now,
                TransactionType = _tranType,
                TransactionAmount = _tranAmount,
                Description = _desc
            };
            //add transaction object to the list
            _listofTransactions.Add(transaction);

        }

        public void ViewTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
