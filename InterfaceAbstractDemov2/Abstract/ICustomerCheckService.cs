using InterfaceAbstractDemov2.Entities;

namespace InterfaceAbstractDemov2.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}