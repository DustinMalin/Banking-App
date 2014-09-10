using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal depositAmount;
            decimal withdrawAmount;

            Account[] accountArray = new Account[2];

            accountArray[0] = new CheckingAccount(1000.00M);

            accountArray[1] = new SavingsAccount(500.00M);


            foreach(Account a in accountArray)
            {
                Console.WriteLine("Please enter the amount you wish to deposit: ");
                depositAmount = Convert.ToDecimal(Console.ReadLine());
                a.Deposit(depositAmount);

                Console.WriteLine("Please enter the amount you wish to withdra: ");
                withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                a.Withdraw(withdrawAmount);

                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();


        }
    }
}
