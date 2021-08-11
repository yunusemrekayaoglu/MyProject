using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Yunus",
                "Emre",
                "Kayaoğlu"
            };

            List<string> names2= new List<string>
            {
                "Yunus",
                "Emre",
                "Kayaoğlu"
            };

            foreach (var name in names2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
