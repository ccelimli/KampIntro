using GameShop.Abstract;
using GameShop.Adapters;
using GameShop.Concrete;
using GameShop.MernisServiceReference;
using System;

namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign1 = new Campaign() { CampaignNo = 1515,CampaignName="Dev İndirim", Category="Teknoloji", Rate=20};
            CampaignManager campaignManager = new CampaignManager();
            Customer customer = new Customer() { ID = 15815, FirstName = "Cagatay", LastName = "Çelimli" ,DateofBirth = new DateTime(1996,5,5),Gender="Erkek",Mail="c.celimli@live.co.uk",Username="ccelimli",Password="123456"};
            Product product = new Product {SeriNo="1252", Category="Teknoloji", Name="Bilgisayar", Price=17.99, Stock=18, isCampign=true};
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(product, customer, campaign1);
            Campaign campaign2 = new Campaign() { CampaignNo = 1516, CampaignName = "Fırsat Ürünü", Category = "Teknoloji", Rate = 50 };
            campaignManager.UpdateCampaign(campaign1, campaign2);
            saleManager.Sale(product, customer, campaign1);

            Customer customer1 = new Customer() { NationalityID = "7532", FirstName = "Cemal", LastName = "Çelimli", ID = 11512, DateofBirth=new DateTime(1996,5,5) }; // Hata mesajı almak için oluşturuldu.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
        }
    } 
}
