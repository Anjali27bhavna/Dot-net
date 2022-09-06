using ATMApp.Domain.Entities;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class ATMApp:IUserLogin
    {
        private List<UserAccounts> userAccountList;
        private UserAccounts selectedAccount;

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;

            UserAccounts tempUserAccount = new UserAccounts();


        }

        public void IntializeData()
        {
            userAccountList = new List<UserAccounts>
            {
                new UserAccounts{Id=1,FullName="Anjali saini", AccountNumber=123456,CardNumber=321321,CardPin=123123,AccountBalance=50000.00m,IsLocked=false},
                new UserAccounts{Id=1,FullName="Nilesh", AccountNumber=456789,CardNumber=654654,CardPin=456456,AccountBalance=40000.00m,IsLocked=false},
                new UserAccounts{Id=1,FullName="Nikhil", AccountNumber=123555,CardNumber=987987,CardPin=789789,AccountBalance=20000.00m,IsLocked=true},

            };
        }
       
    }
}
