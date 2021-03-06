using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceAbstractDemov3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2002, 9, 4), FirstName = "Yunus Emre", LastName = "Kayaoğlu", NationalityId = "xXx" });
            Console.ReadLine();
        }
    }
}
