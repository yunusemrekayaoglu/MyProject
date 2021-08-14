using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class RealCustomer : Customer
    {
        public RealCustomer(int id, string customerId, string nationalityId, string firstName, string lastName)
        {
            Id = id;
            CustomerId = customerId;
            NationalityId = nationalityId;
            FirstName = firstName;
            LastName = lastName;
        }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
