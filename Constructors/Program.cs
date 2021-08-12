using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yunus",
                LastName = "Kayaoğlu",
                City = "Aydın"
            };

            Customer customer2 = new Customer(1, "Yunus", "Emre", "Aydın");
        }
        
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = FirstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Yapıcı blok çalıştı!");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
