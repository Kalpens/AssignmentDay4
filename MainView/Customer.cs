using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainView
{
    public class Customer
    {
        private static int id = 1;
        public int Id { get; }
        public String Name { get; set; }
        public int PhoneNumber { get; set; }

        public Customer(string name, int phoneNumber)
        {
            Name = name;
            Id = id++;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Customer - {Id} - Named - {Name} - Phone number - {PhoneNumber}";
        }
    }
}
