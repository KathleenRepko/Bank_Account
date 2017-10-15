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
        protected int accountNumber;
        protected double accountBalance;
        protected string accountType;


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
            Console.WriteLine("Enter deposit amount:");
            double depositAmount = double.Parse(Console.ReadLine());   
            Console.WriteLine();
            Console.WriteLine("Amount to deposit:\n$" + depositAmount.ToString("0.00"));
            accountBalance = accountBalance + depositAmount;
        }

        public virtual void WithdrawFunds()
        {
            Console.WriteLine("Enter withdrawal amount:");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Amount to withdraw:\n$" + withdrawalAmount.ToString("0.00"));
            accountBalance = accountBalance - withdrawalAmount;
        }

    }

}
