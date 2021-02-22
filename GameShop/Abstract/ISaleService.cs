using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface ISaleService
    {
        void Sale(Product product, Customer customer, Campaign campaign);
        void Return(Product product, Customer customer, Campaign campaign);
    }
}
