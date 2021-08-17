using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
        void Update(Campaign campaign);
    }
}
