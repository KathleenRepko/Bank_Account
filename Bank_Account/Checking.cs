using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Account
    {
        //Constructor:

        public Checking()
        {

        }

        public Checking (int accountNumber, double accountBalance, string accountType)
        {
            this.AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;
            this.AccountType = accountType;
        }

        public override void PrintBalance()
        {
            Console.WriteLine("Current checking balance: $" + AccountBalance); 
        }

        public override void DepositFunds()
        {
            Console.WriteLine("Enter deposit amount:");
            double depositAmount = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Amount to deposit: $" + depositAmount);
            Console.WriteLine("New balance: $" + (accountBalance + depositAmount));
        }

        public override void WithdrawFunds()
        {
            Console.WriteLine("Enter withdrawal amount:");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Amount to withdraw: $" + withdrawalAmount);
            Console.WriteLine("New balance: $" + (accountBalance - withdrawalAmount));
        }


    }
}
