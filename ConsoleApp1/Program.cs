using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //First Product
            Product product_1 = new Product();
            product_1.productID = 1111;
            product_1.productType = "Stationery";
            product_1.productName = "Pencil";
            product_1.productColour = new string[] { "Black", "Blue", "Yellow", "Green", "White" };
            product_1.productUnit = 158;

            //Second Product
            Product product_2 = new Product();
            product_2.productID = 1122;
            product_2.productType = "Kitchen";
            product_2.productName = "Cup";
            product_2.productColour = new string[] { "Cyan", "Brown", "Yellow", "Green", "White", "Pink" };
            product_2.productUnit = 65;

            //Third Product
            Product product_3 = new Product();
            product_3.productID = 1133;
            product_3.productType = "Clothes";
            product_3.productName = "Hat";
            product_3.productColour = new string[] { "Cyan", "Brown", "Yellow", "Green", "White", "Pink","Black"};
            product_3.productUnit = 73;

            Product[] product = new Product[] { product_1, product_2, product_3 };

            foreach (var products in product)
            { 
                Console.WriteLine("Product's ID: {0} ",products.productID);
                Console.WriteLine("Product's Type: " + products.productType);
                Console.WriteLine("Product's Name: " + products.productName);
                foreach (var item in products.productColour)
                {
                    Console.WriteLine("Colour:"+item);
                }
                Console.WriteLine("Product's Unit:{0} " , products.productUnit);
                Console.WriteLine("\n***********************************************\n");
                
            }
        }
    }
}
 class Product
{
    public int productID { get; set; }
    public string productType { get; set; }
    public string productName { get; set; }
    public string[] productColour { get; set; }
    public int productUnit { get; set; }
}