using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {
        //setting fields
        protected int balance = 2000;
        private int deposit;
        private int withdraw;

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int balance)
        {
            this.balance = balance;
        }

        //Method

        public override int Deposit(int deposit)
        {
            return deposit += Balance;
        }

        public override int Withdraw(int withdraw)
        {
            return balance -= withdraw;
        }
        public override void GetBalance()
        {
            Console.WriteLine(balance.ToString());
        }

    }
}
