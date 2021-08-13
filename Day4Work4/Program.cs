using System;

namespace Day4Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "Akif");
            students.Add(2, "Mehmet");
            students.Add(3, "Yunus");
            students.Add(4, "Emre");

            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
