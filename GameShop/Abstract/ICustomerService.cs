using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface ICustomerService 
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
