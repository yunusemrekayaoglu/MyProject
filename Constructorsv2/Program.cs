using System;

namespace Constructorsv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Yunus Emre", "Kayaoğlu", "Aydın");

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
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Constructors has been successfully worked!");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
