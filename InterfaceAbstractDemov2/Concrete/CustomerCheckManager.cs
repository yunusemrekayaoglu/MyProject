using InterfaceAbstractDemov2.Abstract;
using InterfaceAbstractDemov2.Entities;

namespace InterfaceAbstractDemov2.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}