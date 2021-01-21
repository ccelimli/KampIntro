using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi_1, int sayi_2)
        {
            int sonuc = sayi_1 + sayi_2;
            Console.WriteLine("Sonuc: {0}" , sonuc);
        }
        public void Cikart(int sayi_1, int sayi_2)
        {
            
            int sonuc = sayi_1 - sayi_2;
            Console.WriteLine("Sonuc: {0}" , sonuc);
        }
        public void Carp(int sayi_1, int sayi_2)
        {
            int sonuc = sayi_1 * sayi_2;
            Console.WriteLine("Sonuc: {0}" , sonuc);
        }
        public void Bol(float sayi_1, float sayi_2)
        {
            float sonuc = sayi_1 / sayi_2;
            Console.WriteLine("Sonuc: {0}" , sonuc);
        }
        public void Mod(int sayi_1, int sayi_2)
        {
            int sonuc = sayi_1 % sayi_2;
            Console.WriteLine("Sonuc: {0}" , sonuc);
        }
    }
}
