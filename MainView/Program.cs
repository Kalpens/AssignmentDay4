using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainView
{
    class Program
    {

        static void Main(string[] args)
        {
            var customer1 = new Customer("John", 95854562);
            var customer2 = new Customer("Peter", 85496525);
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.ReadLine();
        }
    }
}
