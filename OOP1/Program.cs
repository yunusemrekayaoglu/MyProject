using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id              = 1,
                CategoryId      = 1,
                ProductName     = "Masa",
                UnitPrice       = 300,
                UnitsInStock    = 50
            };
            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "Sandalye",
                UnitPrice = 2300,
                UnitsInStock = 150
            };
            Product product3 = new Product()
            {
                Id = 3,
                CategoryId = 3,
                ProductName = "Laptop",
                UnitPrice = 3100,
                UnitsInStock = 503
            };
            Product[] products = new Product[] { product1, product2, product3 };

            ProductManager productManager = new ProductManager();

            foreach (var product in products)
            {
                productManager.Add(product);
            }
        }
    }
}
