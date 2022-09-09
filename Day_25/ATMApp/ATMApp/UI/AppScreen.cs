using ATMApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal const string cur = "Rs";
        internal static void Welcome()
        {

            //clears the console screen
            Console.Clear();
            //sets the title of the console window
            Console.Title = "My ATM App";
            //sets the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\n\n---------------Welcome to My ATM App----------------\n\n");

            //prompt the user to insert atm card
            Console.WriteLine("Please insert yout ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card, read the card number and validate it");
            Utility.PressEnterToContinue();
        }

        internal static UserAccounts UserLoginForm()
        {
            UserAccounts tempUserAccount = new UserAccounts();

            tempUserAccount.CardNumber = Validate.Convert<long>("your card number. ");

            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("Checking card number and PIN...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to the nearest brach to unlock your account. Thank You", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }

        internal static void WelcomeCustomer(string fullname)
        {
            Console.WriteLine($"Welcome back,{fullname}");
            Utility.PressEnterToContinue();
        }

        internal static void DisplayAppMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------My ATM Menu----------------");
            Console.WriteLine(":                                        :");
            Console.WriteLine("1. Account Balance                       :");
            Console.WriteLine("2. Cash Deposit                          :");
            Console.WriteLine("3. Withdrawal                            :");
            Console.WriteLine("4. Transfer                              :");
            Console.WriteLine("5. Transactions                          :");
            Console.WriteLine("6. Logout                                :");
        }

        internal static void LogOutProgress()
        {
            Console.WriteLine("Thank you for using My ATM App.");
            Utility.PrintDotAnimation();
            Console.Clear();
        }
        internal static int SelectAmount()
        {
            Console.WriteLine("");
            Console.WriteLine(":1. Rs 500          5. Rs 10,000");
            Console.WriteLine(":2. Rs 1000         6. Rs 15000");
            Console.WriteLine(":3. Rs 2000         7. Rs 20,000");
            Console.WriteLine(":4. Rs 5000         8. Rs 40,000");
            Console.WriteLine(":0. Other");
            Console.WriteLine("");

            int selectedAmount = Validate.Convert<int>("option:");
            switch(selectedAmount)
            {
                case 1:
                    return 500;
                    break;
                case 2:
                    return 1000;
                    break;
                case 3:
                    return 2000;
                    break;
                case 4:
                    return 5000;
                    break;
                case 5:
                    return 10000;
                    break;
                case 6:
                    return 15000;
                    break;
                case 7:
                    return 20000;
                    break;
                case 8:
                    return 40000;
                    break;
                case 0:
                    return 0;
                    break;
                default:
                    Utility.PrintMessage("Invalid input. Try again", false);
                    //SelectAmount();
                    return -1;
                    break;


            }
        }

    }
}
