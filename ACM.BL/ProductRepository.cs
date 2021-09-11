using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if(productId == 2)
            {
                product.CurrentPrice = 15.96M;
                product.ProductDescription = "cool sunflowers";
                product.ProductName = "Sunflowers";
            }

            Object myObject = new Object();
            Console.WriteLine($"Obj: {myObject.ToString()}");
            Console.WriteLine($"Prod: {product.ToString()}");
            return product;
        } 
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //Вставка в память
                    }
                    else
                    {
                        //Обновить данные
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
