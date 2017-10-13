﻿using System;
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


        //Constructor:
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
            Console.WriteLine("Current balance: $" + AccountBalance);
        }

        public override void WithdrawFunds()
        {
            double withdrawalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter withdrawal amount:");
            Console.WriteLine();
            do
            {
                Console.WriteLine("You wish to withdraw more than is available your account.\nPlease enter an amount that is less than your current balance.");

            }
            while (withdrawalAmount < AccountBalance);
            Console.WriteLine("Amount to withdraw: $" + withdrawalAmount);
            Console.WriteLine("New balance: $" + (AccountBalance - withdrawalAmount));


        }
    }
}