using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("ID", "1212");
            myDictionary.Add("Name","Cagatay");
            myDictionary.Add("Surname","Celimli");      
        }
    }
}
