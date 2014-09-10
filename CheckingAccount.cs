using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class CheckingAccount : Account
    {


        //constructor
        public CheckingAccount(decimal balance) : base (balance)
        {
            Balance = balance;
        }

        public decimal Balance { get; set; }


        public override decimal Deposit(decimal deposit)
        {
            Balance += deposit;
            return Balance;
        }


        public override decimal Withdraw(decimal withdraw)
        {
            Balance -= withdraw;
            return Balance;
        }


    }
}
