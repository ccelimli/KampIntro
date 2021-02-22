using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<Key,Value>
    {
        Key[] keys; // I created two arrays for Value and Key. 
        Value[] values;

        public MyDictionary()// Constructer. When starting the program, firstly, it will create two addresses for two arrays in the part of the heap in the memory.
        {
            keys = new Key[0]; 
            values = new Value[0];
        }
        public void Add(Key _key, Value _value)
        {
            Key[] tempKey = keys; //I created two arrays more for Value and Key. These arrays keep previous keys and values.
            Value[] tempValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i <tempKey.Length ; i++)
            {
                tempKey[i] = keys[i];       //in the loop, the keeping process is completed.
                tempValue[i] = values[i];
            }
            keys[keys.Length - 1] = _key;           //Finally, Items are assigned to the last element of the arrays
            values[values.Length - 1] = _value;
        }
    }
}
