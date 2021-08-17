using InterfaceAbstractDemov3.Entities;

namespace InterfaceAbstractDemov3.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
