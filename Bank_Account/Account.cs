using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account
    {
        //Fields:
        private int accountNumber;
        private double accountBalance;
        private string accountType;

        //Properties:
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        } 

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }


        //Constructor - none, because this is an abstract class.


        //Methods:
        //abstract method
        public abstract void PrintBalance();

        public virtual void DepositFunds()
        {
            double depositAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter deposit amount:");
            Console.WriteLine();
            Console.WriteLine("Amount to deposit: $" + depositAmount);
            Console.WriteLine("New balance: $" + (accountBalance + depositAmount));
        }

        public virtual void WithdrawFunds()
        {
            double withdrawalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter withdrawal amount:");
            Console.WriteLine();
            Console.WriteLine("Amount to withdraw: $" + withdrawalAmount);
            Console.WriteLine("New balance: $" + (accountBalance - withdrawalAmount));
        }




    }
}
