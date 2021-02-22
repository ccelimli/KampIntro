using GameShop.Adapters;
using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public class CustomerCheckService : ICustomerCheckService
    {
        public bool CheckRealCustomer(Customer customer)
        {
            if (customer.NationalityID == "123456" && customer.FirstName == "Cagatay" && customer.LastName == "Celimli")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
