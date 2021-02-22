using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.MernisServiceReference
{
    public class Product : IEntity
    {
        public string SeriNo { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool isCampign { get; set; } //Kampanya içermesi halinde true olur. Kampanya yoksa false döner ve ürünün normal fiyatı geçerli olur.
        public string BillingCode { get; set; } //Ürün iadesinde kullanıldı.
    }
}
