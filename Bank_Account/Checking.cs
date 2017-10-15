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
            Console.WriteLine("Current balance of checking account #" + accountNumber + ":\n$" + accountBalance.ToString("0.00")); 
        }

        public override void DepositFunds()
        {
            base.DepositFunds();
            Console.WriteLine("New checking account balance:\n$" + accountBalance.ToString("0.00"));
        }

        public override void WithdrawFunds()
        {
            base.WithdrawFunds();
            Console.WriteLine("New checking balance:\n$" + accountBalance.ToString("0.00"));
            if (accountBalance < 0)
                Console.WriteLine("YOUR ACCOUNT IS OVERDRAWN!");
        }

    }

}
