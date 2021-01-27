using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProducName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product_2 = new Product { ID = 2, CategoryID=5, UnitInStock=5, ProducName="Kalem", UnitPrice=35 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);
        }
    }
}
