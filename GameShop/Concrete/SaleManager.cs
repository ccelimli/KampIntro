using GameShop.Abstract;
using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    public class SaleManager : ISaleService
    {
        //Satış
        public void Sale(Product product, Customer customer, Campaign campaign)
        {
            if (product.isCampign == true) //Kampanya varsa if bloğu, kampanya yoksa else bloğu çalışır.
            {
                double newPrice = (product.Price) - ((product.Price) * (campaign.Rate / 100));
                Console.WriteLine("{0} {1} {2} ({3} TL) satın aldı.",customer.FirstName,customer.LastName,product.Name,newPrice);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} ({3} TL) satın aldı.", customer.FirstName, customer.LastName, product.Name, product.Price);
            }
        }
        //Ürün İade
        public void Return(Product product, Customer customer, Campaign campaign )
        {
            if (product.isCampign == true)
            {
                double newPrice = (product.Price) - ((product.Price) * (campaign.Rate / 100));
                Console.WriteLine("{0} {1} {2} ({3} TL) iade etti.", product.BillingCode,customer.FirstName, customer.LastName, product.Name, newPrice);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} ({3} TL) iade etti.", product.BillingCode, customer.FirstName, customer.LastName, product.Name, product.Price);
            }
        }


    }
}
