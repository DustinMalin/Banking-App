using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {


        //constructor
        public Account(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance { get; set; }


        //Deposit method
        public virtual decimal Debit(decimal deposit)
        {
            Balance += deposit;
            return Balance;
        }


        //Withdraw method
        public virtual decimal Credit(decimal withdraw)
        {
            Balance -= withdraw;
            return Balance;
        }

        public override string ToString()
        {
            return string.Format("The new balance is now {0}", Balance);
        }


    }
}
