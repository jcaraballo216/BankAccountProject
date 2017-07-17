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
            //instantiating
            //not working "problems" 
            CheckingAccount tigerChecking = new CheckingAccount();
            SavingsAccount tigerSavings = new SavingsAccount();


            string numChoice;
            string numChoice2;
            int deposit;
            int withdraw;


            //Greeting message
            do
            {
                Client name1 = new Client("Tiger Woods", "Cleveland", 01234);
                name1.Info();
                Console.WriteLine("Welcome to PGA Bank!\n");
                Console.WriteLine("Please pick from the following menu!\n");
                //setting the menu
                Console.WriteLine(" 1. View Client Information\n 2. View Account Balance\n 3. Deposit Funds\n 4. Withdraw Funds\n 5. Exit");
                numChoice = Console.ReadLine();

                //using if for number choices

                if (numChoice == "1")
                {
                    Client name2 = new Client("Tiger Woods", "Cleveland", 01234);
                    name1.Info2();
                }
                //Balance ouput
                if (numChoice == "2")
                {
                    //spent a lot of time on this loop couldnt get it to work until I Played with it
                    do
                    {
                        Console.WriteLine("1. Checking Account\n2. Savings Account");
                        numChoice2 = Console.ReadLine();

                        if (numChoice2 == "1")
                        {
                            Console.WriteLine("Your current balance is: ");
                            tigerChecking.GetBalance();

                        }
                        if (numChoice2 == "2")
                        {
                            Console.WriteLine("Your current balance is: ");
                            tigerSavings.GetBalance();

                        }

                    } while (numChoice2 != "2");
                }
                if (numChoice == "3")
                {
                    do
                    {
                        Console.WriteLine("1. Checking Account\n2. Savings Account");
                        numChoice2 = Console.ReadLine();

                        //I was not able to get the deposit / withdraw and balance to add.
                        if (numChoice2 == "1")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            deposit = int.Parse(Console.ReadLine());
                            tigerChecking.Balance = tigerChecking.Deposit(deposit);
                            tigerChecking.GetBalance();
                        }
                        if (numChoice2 == "2")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            deposit = int.Parse(Console.ReadLine());
                            tigerSavings.Balance = tigerSavings.Deposit(deposit);
                            tigerSavings.GetBalance();
                        }
                    } while (numChoice != "3");
                    if (numChoice == "4")
                    {
                        do
                        {
                            Console.WriteLine("1. Checking Account\n2. Savings Account");
                            numChoice2 = Console.ReadLine();
                            if (numChoice2 == "1")
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                withdraw = int.Parse(Console.ReadLine());
                                tigerChecking.Withdraw(withdraw);
                                tigerChecking.GetBalance();
                            }
                            if (numChoice2 == "2")
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                withdraw = int.Parse(Console.ReadLine());
                                tigerSavings.Withdraw(withdraw);
                                tigerSavings.GetBalance();
                            }
                        } while (numChoice != "4");

                    }

                }
            } while (numChoice != "5");
        }
    }
}
