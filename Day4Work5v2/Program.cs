using System;

namespace Day4Work5v2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "a");
            students.Add(2, "b");
            students.Add(3, "c");
            students.Add(4, "d");

            foreach (var student in students.Keys)
            {
                Console.WriteLine(student);
            }
        }
    }
}
