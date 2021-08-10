using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Başarıyla sepete eklendi!" + product.Adi);
        }

        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Başarıyla seppete eklendi!" + urunAdi);
        }
    }
}
