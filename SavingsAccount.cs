using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class SavingsAccount : Account
    {

        public SavingsAccount(decimal balance) : base (balance)
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

        public decimal CalculateInterest()
        {
            Balance = (Balance / 1);
            return Balance; 
        }
        
    }
}
