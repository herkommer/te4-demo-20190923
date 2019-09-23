using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beskriv vad du vill uppnå!

            //Test
            ArrayList Customers = new ArrayList();
            Customers.Add(new Customer() { FirstName = "Kalle", LastName = "Anka" });
            Customers.Add(new Customer() { FirstName = "Arne", LastName = "Anka" });

            Console.WriteLine(Customers.Count);

            foreach (Customer c in Customers)
            {
                Console.WriteLine("{0} {1}", c.FirstName, c.LastName);
            }
        }
    }
}
