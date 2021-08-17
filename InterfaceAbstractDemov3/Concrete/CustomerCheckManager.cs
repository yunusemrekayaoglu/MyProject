using InterfaceAbstractDemov3.Abstract;
using InterfaceAbstractDemov3.Entities;

namespace InterfaceAbstractDemov3.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
