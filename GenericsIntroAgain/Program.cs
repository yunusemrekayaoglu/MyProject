using System;

namespace GenericsIntroAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("asd");

            Console.WriteLine(names.Length);
            names.Add("asfg");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
