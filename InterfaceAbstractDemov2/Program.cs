using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemov2.Abstract;
using InterfaceAbstractDemov2.Concrete;
using InterfaceAbstractDemov2.Entities;
using InterfaceAbstractDemov2.Abstract;
using InterfaceAbstractDemov2.Adapters;

namespace InterfaceAndAbstractDemov2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "" });
            Console.ReadLine();
        }
    }
}