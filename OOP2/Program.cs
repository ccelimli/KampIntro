using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cagatay Celimli
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNum = "1255";
            customer1.Name = "Cagatay";
            customer1.Surname = "Celimli";
            customer1.CitizenshipNum = "12451281182";

            //Kurumsal Musteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNum = "52888";
            customer2.CompanyName = "KM";
            customer2.TaxNum = "15935778";
            Customer customer3 = new IndividualCustomer(); 
            Customer customer4 = new CorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        } 
    }
}

/*
 *  Notlar:
 *  1- 
 *      Customer customer3=new IndividualCustomer();     ----->  Musteri, hem Individual hem de Corporate in referansını tutabilir
 *      Customer customer4=new CorporateCustomer();
 *  
 * 
 * 
 * 
 */
