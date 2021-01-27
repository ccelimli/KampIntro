using System;
using System.Collections.Generic; //used to collection

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string> {"Istanbul","Ankara","Izmir","Eskisehir" };
            cities.Add("Trabzon");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
