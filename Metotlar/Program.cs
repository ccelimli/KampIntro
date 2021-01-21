using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetManager sepetManager = new SepetManager();
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elmasi";

            Urun urun_1 = new Urun();
            urun_1.Id = 121;
            urun_1.Adi = "Elma";
            urun_1.Fiyat = 15;
            urun_1.Aciklama = "Amasya Elması";
            urun_1.StokAdedi = 511;

            Urun urun_2 = new Urun();
            urun_2.Id = 112;
            urun_2.Adi = "Karpuz";
            urun_2.Fiyat = 80;
            urun_2.Aciklama = "Diyabakir Karpuzu";
            urun_2.StokAdedi = 1515;

            Urun[] urunler = new Urun[] { urun_1, urun_2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                sepetManager.Ekle(urun);
                Console.WriteLine("***************************************");            
            }
            Console.WriteLine("---------------------Metodlar----------------");
            //instance-ornek
            //encapsulation
            
            

        }
    }
}

//Dont repeat yourself
