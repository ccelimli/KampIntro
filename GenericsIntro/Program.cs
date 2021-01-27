using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> cities = new MyList<string>();
            cities.Add("Ankara");
        }
    }
}
