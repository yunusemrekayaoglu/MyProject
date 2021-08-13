using System;

namespace ReferenceTypesv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Yunus Emre", "Kayaoğlu");


            Customer customer1 = new Customer() { FirstName = "Kaya", CreditCardNumber = "12312312" };
            Employee employee1 = new Employee() { FirstName = "ZA" };

            Person person3 = customer1;

            Console.WriteLine(((Customer)customer1).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee1);
        }
    }

    class Person
    {
        public Person()
        {

        }
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine(firstName); //person 1
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
