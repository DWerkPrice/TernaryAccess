using System;

namespace TernaryAccess
{
    class Program
    {
        static void Main(string[] args) {
            var cust1 = new Customer { Id = 1 , Name = "Max Technical Training" };
            cust1.NationalAccount("yes");

            var oorder1 = new Order { Id = 1 , Amount = 1000 , Customer = cust1 };

        }
    }
}
