using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate client, checking account, and savings account.
            //Hard code the client and account information:
            Client client1 = new Client("Clark", "Howard", 12538);
            Checking checking1 = new Checking(18735426, 548.23, "checking");
            Savings savings1 = new Savings(29957352, 2941.15, "savings", 2500.00);


            Console.WriteLine("Welcome to Trustus National Bank! Thank you for banking with us.\n");
            

            //Declare variables:
            int userPick;
            int userType;
            

            //Create and print client menu. Do-while loop allows user to exit the program.
            Console.WriteLine("\nPlease enter the number of your desired menu option and then click \"Enter\":");
            do { 
                List<string> clientMenu = new List<string> { "1. View your user profile.", "2. View your account balance.", "3. Make a deposit.", "4. Make a withdrawal.", "5. Exit." };
                foreach (string menuChoice in clientMenu)
                {
                    Console.WriteLine("\t" + menuChoice);
                }
                Console.WriteLine();

                userPick = int.Parse(Console.ReadLine());

                //Conditionals based on user's pick of menu choice:
                switch (userPick)
                {
                    case 1:
                        Console.WriteLine();
                        client1.PrintClientInfo();
                        Console.WriteLine("\nWhat would you like to do next?");
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("\nWhat is the account type?\nEnter number of menu option:\n\t1. checking\n\t2. savings\n");
                            userType = int.Parse(Console.ReadLine());

                            switch (userType)
                            {
                                case 1:
                                    Console.WriteLine();
                                    checking1.PrintBalance();
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    savings1.PrintBalance();
                                    break;
                                default:
                                    Console.WriteLine("\nPlease enter a valid option.");
                                    break;
                            }
                        } while (userType != 1 && userType != 2);
                        Console.WriteLine("\nWhat would you like to do next?");
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("\nInto which account type would you like to make a deposit?\nEnter number of the menu option:\n\t1. checking\n\t2. savings\n");
                            userType = int.Parse(Console.ReadLine());

                            switch (userType)
                            {
                                case 1:
                                    Console.WriteLine();
                                    checking1.DepositFunds();
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    savings1.DepositFunds();
                                    break;
                                default:
                                    Console.WriteLine("\nPlease enter a valid option.");
                                    break;
                            }
                        } while (userType != 1 && userType != 2);
                        Console.WriteLine("\nWhat would you like to do next?");
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("\nFrom which account type would you like to make a withdrawal?\nEnter the number of the menu option:\n\t1. checking\n\t2. savings\n");
                            userType = int.Parse(Console.ReadLine());

                            switch (userType)
                            {
                                case 1:
                                    Console.WriteLine();
                                    checking1.WithdrawFunds();
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    savings1.WithdrawFunds();
                                    break;
                                default:
                                    Console.WriteLine("\nPlease enter a valid option.");
                                    break;
                            }
                        } while (userType != 1 && userType != 2);
                        Console.WriteLine("\nWhat would you like to do next?");
                        break;
                    case 5:
                        Console.WriteLine("\nIt has been a pleasure serving you!\n");
                        break;
                    default:
                            Console.WriteLine("\nPlease choose a valid option.");
                            break;
                }
            } while (userPick != 5);


        }

    }

}

          
        
    

