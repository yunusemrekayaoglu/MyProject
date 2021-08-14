using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Work5v2
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeyArray = _key;
            _key = new TKey[_key.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _key[i] = tempKeyArray[i];
            }
            _key[_key.Length - 1] = key;

            TValue[] tempValueArray = _value;
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < tempValueArray.Length; i++)
            {
                _value[i] = tempValueArray[i];
            }
            _value[_value.Length - 1] = value;
        }

        public TKey[] Keys
        {
            get { return _key; }
        }
        public TValue[] Values
        {
            get { return _value; }
        }
        public int Count
        {
            get { return _value.Length; }
        }
    }
}
