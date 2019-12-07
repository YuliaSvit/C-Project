using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class Transaction:ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction (string c,string d,double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }
    }
}
