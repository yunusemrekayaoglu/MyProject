using System;
using System.Collections.Generic;

namespace Genericsv2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> cities = new MyList<string>();
            cities.Add("a");
            cities.Add("b");
            cities.Add("c");
            cities.Add("d");
            Console.WriteLine(cities.Count);
        }



    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        private int _count;

        public int Count
        {
            get { return _count; }
        }
    }
}
