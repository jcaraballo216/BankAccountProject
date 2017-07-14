using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //Setting field

        private string name = "Tiger Woods";
        private string address = "3268 Cleveland, OH";
        private int accountNum = 01234;

        //Properties

        public string Name
        {
            get { return this.name; }
            
        }
        public string Address
        {
            get { return this.address; }
            
        }
        public int AccountNum
        {
            get { return this.accountNum; }
           
        }
        //Constructor

        public Client()
        {

        }
        public Client (string name, string address, int accountNum)
        {
            this.name = name;
            this.address = address;
            this.accountNum = accountNum;
        }
        //Method
        public void Info()
        {
            Console.WriteLine("Welcome Back " + name);
            
        }
        public void Info2()
        {
            Console.WriteLine("Tiger Woods");
            Console.WriteLine("3268 Cleveland, OH");
            Console.WriteLine("Account Number: 01234");
        }
       


    }
}
