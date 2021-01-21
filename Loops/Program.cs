using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] kurslar=new string[] {
                                            "Yazılım Gelistirici Yetistirme Kampı", "Progrmalamaya baslangic icin temel kurs", "Java", "Python","C#"
                                           };
            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine("{0} - {1} ",i+1,kurslar[i]);
            }
            Console.WriteLine("\n\nSayfa Sonu -- Footer\n\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            */
            int sayi = 3;
            bool sonuc=sayi % 2 == 0 ?  true :  false;
            Console.WriteLine(sonuc);
        }
    }
}
