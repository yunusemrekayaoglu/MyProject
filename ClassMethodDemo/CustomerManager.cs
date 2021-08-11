using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
     class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerFirstName + " is successfully added!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerFirstName + "is successfully removed!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.CustomerFirstName + "is successfully updated!");
        }
    }
}
