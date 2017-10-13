using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        private static readonly int userPick;

        static void Main(string[] args)
        {
            Client client1 = new Client("Repko", "Kathleen", 44060);
            Checking checking1 = new Checking(18735426, 548.23, "checking");
            Savings savings1 = new Savings(29957352, 2941.15, "savings", 2500.00);

            Console.WriteLine("Welcome to Trustus National Bank! Thank you for banking with us.\n");

            do
            {
                Console.WriteLine("Please enter the number of your desired menu option and then click \"Enter\":");
                List<string> clientMenu = new List<string> { "1. View your user profile.", "2. View your account balance.", "3. Make a deposit.", "4. Make a withdrawal.", "5. Exit." };
                foreach (string menuChoice in clientMenu)
                {
                    Console.WriteLine(menuChoice);
                }
                Console.WriteLine();



                int userPick = int.Parse(Console.ReadLine());
                int userType;
                int userType2;

                switch (userPick)
                {
                    case 1:
                        client1.PrintClientInfo();
                        break;
                    case 2:
                        Console.WriteLine("What is the account type?\nEnter number of menu option:\n\t1. checking\n\t2. savings\n");
                        userType = int.Parse(Console.ReadLine());
                        if (userType == 1)
                        {
                            checking1.PrintBalance();
                        }
                        else
                        {
                            savings1.PrintBalance();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Into which account type would you like to make a deposit?\nEnter number of the menu option:\n\t1. checking\n\t2. savings\n");
                        userType = int.Parse(Console.ReadLine());
                        if (userType == 1)
                        {
                            checking1.DepositFunds();
                        }
                        else
                        {
                            savings1.DepositFunds();
                        }
                        break;
                    case 4:
                        Console.WriteLine("From which account type would you like to make a withdrawal?\nEnter the number of the menu option:\n\t1. checking\n\t2. savings\n");
                        userType2 = int.Parse(Console.ReadLine());
                        if (userType2 == 1)
                        {
                            checking1.WithdrawFunds();
                        }
                        else
                        {
                            savings1.WithdrawFunds();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you for banking with us.");
                        break;

                }
            }
            while (userPick != 5);



                //Console.WriteLine("It has been our pleasure to serve you.");
            
        }
    }
}
