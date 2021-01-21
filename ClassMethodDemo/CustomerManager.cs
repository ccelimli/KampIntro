using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void customerAdd(Customer customer)
        {
            Console.WriteLine("{0}-" + customer.firstName + " " + customer.lastName+ " successfully added!", customer.ID);
        }
        public void customerDelete(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }
        public void printCustomer(Customer customer) 
        {
            Console.WriteLine("ID: "+customer.ID);
            Console.WriteLine("Full Name: "+customer.firstName+" "+customer.lastName);
            Console.WriteLine("Phone Number: "+customer.phoneNumber);
            Console.WriteLine("Address: "+customer.Address);
            Console.WriteLine("\n");
            customerAdd(customer);
        }
    }
}
