using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Account
    {
        //Constructors:

        public Checking()
        {

        }

        public Checking (int accountNumber, double accountBalance, string accountType)
        {
            this.AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;
            this.AccountType = accountType;
        }

        //Methods:
        public override void PrintBalance()
        {
            Console.WriteLine("Current balance of checking account #" + accountNumber + ":\n$" + accountBalance); 
        }

        public override void DepositFunds()
        {
            Console.WriteLine("Enter deposit amount:");
            double depositAmount = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Amount to deposit to checking:\n$" + depositAmount.ToString("0.00"));
            accountBalance = accountBalance + depositAmount;
            Console.WriteLine("New checking account balance:\n$" + accountBalance.ToString("0.00"));
        }

        public override void WithdrawFunds()
        {
            Console.WriteLine("Enter withdrawal amount:");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Amount to withdraw from checking:\n$" + withdrawalAmount.ToString("0.00"));
            accountBalance = accountBalance - withdrawalAmount;
            Console.WriteLine("New checking balance:\n$" + accountBalance.ToString("0.00"));
        }


    }
}
