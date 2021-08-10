using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] 
                { 
                    "C#",
                    "JS",
                    "C++",
                    "C"
                };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
