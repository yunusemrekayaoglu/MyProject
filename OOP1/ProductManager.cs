using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " has been successfully added!");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " has been successfully updated!");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " has been succesfully removed!");
        }
    }
}
