using System;
using InterfaceAbstractDemov2.Abstract;
using InterfaceAbstractDemov2.Concrete;
using InterfaceAbstractDemov2.Entities;

namespace InterfaceAbstractDemov2.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }

        public static implicit operator BaseCustomerManager(NeroCustomerManager v)
        {
            throw new NotImplementedException();
        }
    }
}