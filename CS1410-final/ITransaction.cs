using System;
using System.Collections.Generic;
using System.Text;

namespace CS1410_final
{
    interface ITransaction
    {
        void InsertTransaction(BankAccount bankAccount, Transaction transaction);

        void ViewTransaction(BankAccount bankAccount);
    }
}
