using GameShop.Abstract;
using GameShop.Adapters;
using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    public class CustomerManager:ICustomerService
    {
        CustomerCheckService customerCheckService = new CustomerCheckService();

        public void Add(Customer customer)
        {
            if (customerCheckService.CheckRealCustomer(customer))
            {
                Console.WriteLine("{0} - Müşteri Eklendi", customer.ID); ;
            }
            else
            {
                Console.WriteLine("Geçersiz Müşteri");
            }
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
