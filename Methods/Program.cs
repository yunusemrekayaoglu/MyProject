using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Adi = "Elma", Fiyati = 30, Aciklama = "Ucuz"};
            Product product2 = new Product() { Adi = "Armut", Fiyati = 50, Aciklama = "Pahalı" };
            Product product3 = new Product() { Adi = "Karpuz", Fiyati = 100, Aciklama = "Ayp" };

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);

            sepetManager.Add2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil Elma", 15, 10);
            sepetManager.Add2("Muz", "Sapsarı", 13, 20);
        }
    }
}
