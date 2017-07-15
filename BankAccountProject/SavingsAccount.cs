using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {
        protected int accountNumber = 01234;
        protected double balance = 2000.00d;
        protected string accountType = "Savings";

        private int deposit;
        private int withdrawl;

        public SavingsAccount()
        {

        }

        public override void GetBalance()
        {
            Console.WriteLine("Your current balance is: $" + balance);
        }

        public override void Deposit()
        {
            Console.WriteLine("How much would you like to deposit? " (balance + deposit));
            deposit = int.Parse(Console.ReadLine());
        }

        public override void Withdraw()
        {
            Console.WriteLine("How much would you like to withdrawl? " + withdrawl);
            withdrawl = int.Parse(Console.ReadLine());
        }
    }
}
