using System;
using InterfaceAbstractDemov3.Abstract;
using InterfaceAbstractDemov3.Entities;
using InterfaceAbstractDemov3.MernisServiceReference;

namespace InterfaceAbstractDemov3.Adapters
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client =new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
