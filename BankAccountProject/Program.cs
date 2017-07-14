using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    { 
        static void Main(string[] args)
        {
            int numChoice;//declaring the variable for menu

            //Greeting message

            Client name1 = new Client("Tiger Woods", "Cleveland", 01234);
            name1.Info();
            Console.WriteLine("Welcome to PGA Bank!\n");
            Console.WriteLine("Please pick from the following menu!\n");
            //setting the menu

            Console.WriteLine(" 1. View Client Information\n 2. View Account Balance\n 3. Deposit Funds\n 4. Withdraw Funds\n 5. Exit");
            numChoice = int.Parse(Console.ReadLine());

            //using if and else if for number choices
            if (numChoice == 1)
            {
                Client name2 = new Client("Tiger Woods", "Cleveland", 01234);
                name1.Info2();
            }
            else if (numChoice == 2)
            {

            }


        }
    }
}
