using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani=1.45;
            bool sisteneGiris = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("->");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("<-");
            }
            else
            {
                Console.WriteLine("--");
            }

            if (sisteneGiris==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
