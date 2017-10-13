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
            Console.WriteLine("Current balance: $" + AccountBalance); 
        }


    }
}
