using System;
using InterfaceAbstractDemov3.Entities;

namespace InterfaceAbstractDemov3.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
           Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
