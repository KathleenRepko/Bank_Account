using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        //Fields:
        private string lastName;
        private string firstName;
        private int zipCode;

        //Three Properties:
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.LastName; }
            set { this.firstName = value; }
        }

        public int ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }


        //Constructor:
        public Client(string lastName, string firstName, int zipCode)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.zipCode = zipCode;
        }


        //Method:
        public void PrintClientInfo()
        {
            Console.WriteLine("Client Name: " + lastName + ", " + firstName);
            Console.WriteLine("Zip Code: " + zipCode);
        }
        

    }
}
