using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {
        protected int balance = 2000;


        public SavingsAccount()
        {

        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public override int Deposit(int deposit)
        {
            return deposit += Balance;
        }

        public override int Withdraw(int withdraw)
        {
            return withdraw -= Balance;
        }

    }
}
