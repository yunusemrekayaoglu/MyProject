using System;

namespace Day2Work6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, CategoryId = 1, UrunAdi = "Laptop", UrunFiyati = 9999, IndirimTutari = 30, DegerlendirmeSayisi = 1000, Yildiz = 3  };
            Product product2 = new Product() { Id = 2, CategoryId = 2, UrunAdi = "Fare", UrunFiyati = 3333, IndirimTutari = 20, DegerlendirmeSayisi = 100, Yildiz = 2 };
            Product product3 = new Product() { Id = 3, CategoryId = 3, UrunAdi = "Kulaklık", UrunFiyati = 99, IndirimTutari = 10, DegerlendirmeSayisi = 21000, Yildiz = 5 };
            
            Product[] urunler = new Product[] { product1, product2, product3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati);
            }

        }
    }

    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string UrunAdi { get; set; }
        public float UrunFiyati { get; set; }
        public int IndirimTutari { get; set; }
        public int DegerlendirmeSayisi { get; set; }
        public double Yildiz { get; set; }


    }
}
