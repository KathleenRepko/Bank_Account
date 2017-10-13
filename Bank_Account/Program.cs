using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Repko", "Kathleen", 44060);

            client1.PrintClientInfo();


        }
    }
}
