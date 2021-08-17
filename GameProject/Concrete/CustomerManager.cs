using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
     class CustomerManager : ICustomerService
    {
        IUserValidationService _userValidationService;
        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Customer customer)
        {
            if (_userValidationService.Validate(customer) == true)
            {
                Console.WriteLine(customer.FirstName + " has been successfully register!");
            }
            else
            {
                Console.WriteLine("The verification is not successfully! Please try again later.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " has been successfully deleted!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " has been successfully updated!");
        }
    }
}
