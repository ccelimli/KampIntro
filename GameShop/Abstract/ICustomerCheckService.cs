using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Adapters
{
    public interface ICustomerCheckService
    {
         public bool CheckRealCustomer(Customer customer);
    }
}
