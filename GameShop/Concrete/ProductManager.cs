using GameShop.Abstract;
using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    public class ProductManager : IProductService
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine("SeriNo: {0}\nKategori: {1}\nÜrün Adı: {2}\nFiyat: {3}\nÜrün Eklendi.",product.SeriNo,product.Category,product.Name,product.Price);
        }

        public void DeleteProduct(Product product)
        {
            Console.WriteLine("SeriNo: {1} Ürün Silindi.",product.SeriNo);
        }

        public void UpdateProduct(Product product)
        {
            Console.WriteLine("SeriNo: {1} Ürün Güncellendi",product.SeriNo);
        }
    }
}
