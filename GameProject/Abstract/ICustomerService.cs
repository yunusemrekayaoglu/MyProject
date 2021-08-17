using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
     interface ICustomerService
    {

        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
