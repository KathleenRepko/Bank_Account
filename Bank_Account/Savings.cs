using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings : Account
    {
        //Field:
        private double minimumBalance;


        //Property:
        public double MinimumBalance
        {
            get { return this.minimumBalance; }
            set { this.minimumBalance = value; }
        }


        //Constructors:
        public Savings()
        {

        }

        public Savings(int accountNumber, double accountBalance, string accountType, double minimumBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;
            this.AccountType = accountType;
            this.minimumBalance = minimumBalance;
        }


        //Methods:
        public override void PrintBalance()
        {
            Console.WriteLine("Current balance of savings account #" + accountNumber + ":\n$" + accountBalance.ToString("0.00"));
        }

        public override void DepositFunds()
        {
            base.DepositFunds();
            Console.WriteLine("New savings account balance:\n$" + accountBalance.ToString("0.00"));
        }

        //Program should not allow user to withdraw funds if account balance will go below minimum balance.
        public override void WithdrawFunds()
        {
            Console.WriteLine("Enter withdrawal amount:");
            double withdrawalAmount;

            do
            {
                withdrawalAmount = double.Parse(Console.ReadLine());
                Console.WriteLine();
                if (withdrawalAmount > (accountBalance - minimumBalance))
                {
                    Console.WriteLine("This withdrawal will take you under your required minimum balance of $" + minimumBalance.ToString("0.00") + ".");
                    Console.WriteLine("Please enter a withdrawal amount that is less than $" + ((accountBalance - minimumBalance) + 0.01).ToString("0.00") + ".\n");
                }
            } while (withdrawalAmount >= (accountBalance - minimumBalance));
        
            Console.WriteLine("Amount to withdraw from savings:\n$" + withdrawalAmount.ToString("0.00"));
            accountBalance = accountBalance - withdrawalAmount;
            Console.WriteLine("New savings account balance:\n$" + accountBalance.ToString("0.00"));
        }

    }

}
