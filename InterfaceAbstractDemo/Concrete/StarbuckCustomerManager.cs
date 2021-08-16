using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbuckCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbuckCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfReaLPerson(customer))
            {
                base.Save(customer);

            }
            else
            {
                throw new Exception("not a valid person");
            } 
        }


    }
}
