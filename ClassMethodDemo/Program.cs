using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                CustomerFirstName = "Yunus Emre",
                CustomerLastName  = "Kayaoğlu"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                CustomerFirstName = "Yaren",
                CustomerLastName = "Kayaoğlu"
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                CustomerFirstName = "Yusuf",
                CustomerLastName = "Kayaoğlu"
            };
            Customer customer4 = new Customer()
            {
                Id = 4,
                CustomerFirstName = "Yasin",
                CustomerLastName = "Kayaoğlu"
            };

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
