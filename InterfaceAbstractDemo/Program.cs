using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

BaseCustomerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer { NationalityId = "288614499108", FirstName = "asd", LastName = "Demiroğ", DateOfBirth = new DateTime(1986,1,6) });
Console.ReadLine();
