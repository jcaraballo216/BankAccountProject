using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : Account
    {
        protected int accountNumber = 01234;
        protected double balance = 2000.00d;
        protected string accountType = "Checking";

        private double deposit;
        private double withdrawl;

        public CheckingAccount()
        {

        }

        public override void GetBalance()
        {
            throw new NotImplementedException();
        }

        public override void Deposit()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
