using ATMApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Domain.Interfaces
{
    public interface ITransaction
    {
        void InsertTransaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string desc);
        void ViewTransaction();
    }
}
