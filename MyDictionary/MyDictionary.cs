using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2, T3>
    {
        T1[] key;
        T1[] tempKey;

        T2[] value;
        T2[] tempValue;

        T3[] value2;
        T3[] tempValue2;

        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];
            value2 = new T3[0];
        }

        public void Add(T1 keys, T2 values, T3 values2)
        {
            tempKey = key;
            tempValue = value;
            tempValue2 = value2;

            key = new T1[key.Length+1];
            value = new T2[value.Length+1];
            value2 = new T3[value2.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
                value2[i] = tempValue2[i];
            }

            key[key.Length-1] = keys;
            value[value.Length-1] = values;
            value2[value2.Length - 1] = values2;
        }

        public int Count
        {
            get { return key.Length;  }
        }

        public T1[] Key
        {
            get { return key; }
        }

        public T2[] Value
        {
            get { return value; }
        }

        public T3[] Value2
        {
            get { return value2; }
        }
    }
}
