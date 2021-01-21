using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ID = 1818111;
            customer.firstName = "Cagatay";
            customer.lastName = "Celimli";
            customer.phoneNumber = "+90-555-55-55";
            customer.Address = "21254. st";

            Customer customer_1 = new Customer();
            customer_1.ID = 212313;
            customer_1.firstName = "John";
            customer_1.lastName = "Kyle";
            customer_1.phoneNumber = "+90-512-32-61";
            customer_1.Address = "31231. sk";

            Customer customer_2 = new Customer();
            customer_2.ID = 512;
            customer_2.firstName = "Jessica";
            customer_2.lastName = "Smith";
            customer_2.phoneNumber = "+212-2311-131-13";
            customer_2.Address = "8174. sk";

            Customer customer_3 = new Customer();
            customer_3.ID = 1818111;
            customer_3.firstName = "Williams";
            customer_3.lastName = "Thomas";
            customer_3.phoneNumber = "+13-5225-43-91";
            customer_3.Address = "2441. sk";

            Customer customer_4 = new Customer();
            customer_4.ID = 1818111;
            customer_4.firstName = "Isla";
            customer_4.lastName = "Taylor";
            customer_4.phoneNumber = "+44-899-78-61";
            customer_4.Address = "1111. sk";

            Customer[] customerList = new Customer[] {customer_1,customer_2,customer_3 };

            foreach (Customer customers in customerList)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.printCustomer(customers);
                Console.WriteLine("\n");
                customerManager.customerAdd(customers);
                Console.WriteLine("\n***************************************************\n");
            }

        }
    }
}
