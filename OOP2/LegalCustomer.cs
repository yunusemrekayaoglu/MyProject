using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class LegalCustomer : Customer
    {

        public LegalCustomer(int id, string customerId, string companyName, string taxNumber)
        {
            Id = id;
            CustomerId = customerId;
            CompanyName = companyName;
            TaxNumber = taxNumber;
        }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
