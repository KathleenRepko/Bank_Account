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
            //Hard code the client and account information:
            Client client1 = new Client("Repko", "Kathleen", 44060);
            Checking checking1 = new Checking(18735426, 548.23, "checking");
            Savings savings1 = new Savings(29957352, 2941.15, "savings", 2500.00);

            Console.WriteLine("Welcome to Trustus National Bank! Thank you for banking with us.\n");

            int userPick;
            int userType;
            //int userType2;
            do
            {
                Console.WriteLine("\nPlease enter the number of your desired menu option and then click \"Enter\":");

                List<string> clientMenu = new List<string> { "1. View your user profile.", "2. View your account balance.", "3. Make a deposit.", "4. Make a withdrawal.", "5. Exit." };
                foreach (string menuChoice in clientMenu)
                {
                    Console.WriteLine("\t" + menuChoice);
                }
                Console.WriteLine();

                userPick = int.Parse(Console.ReadLine());

                switch (userPick)
                {
                    case 1:
                        Console.WriteLine();
                        client1.PrintClientInfo();
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("\nWhat is the account type?\nEnter number of menu option:\n\t1. checking\n\t2. savings\n");
                            userType = int.Parse(Console.ReadLine());
                        
                            switch(userType)
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
                        break;

                    default:
                        Console.WriteLine("\nIt has been a pleasure serving you.");
                        break;
                }
            } while (userPick <= 4);
            
            Console.WriteLine("Have a glorious day.");

        }
    }
}

          
        
    

