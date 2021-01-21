using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            int sayi_1 = 14;
            int sayi_2 = 15;
            dortIslem.Topla(sayi_1, sayi_2);
            dortIslem.Cikart(sayi_1, sayi_2);
            dortIslem.Carp(sayi_1, sayi_2);
            dortIslem.Bol(sayi_1, sayi_2);
            dortIslem.Mod(sayi_1, sayi_2);

        }
    }
}
