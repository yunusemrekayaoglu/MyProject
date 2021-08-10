using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs() { KursAdi = "C#", Egitmen = "Engin Demirog", IzlenmeOrani = 35 };
            Kurs kurs2 = new Kurs() { KursAdi = "C++", Egitmen = "Demirog", IzlenmeOrani = 45 };
            Kurs kurs3 = new Kurs() { KursAdi = "C", Egitmen = "Engin ", IzlenmeOrani = 55 };

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
