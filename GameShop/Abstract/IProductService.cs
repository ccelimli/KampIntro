using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
    }
}
