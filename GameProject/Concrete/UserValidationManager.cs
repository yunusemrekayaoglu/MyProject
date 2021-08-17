using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.FirstName == "Yunus Emre" && customer.LastName == "Kayaoğlu" && customer.NationalitId == "3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
