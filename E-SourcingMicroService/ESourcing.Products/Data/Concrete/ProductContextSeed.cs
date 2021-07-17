using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data.Concrete
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name = "Lenovo Laptop",
                    Summary = "Birincisi Sınıf Laptop",
                    Description = "Al bu kirazdan Kalmaz Birazdan",
                    ImageFile = "latpop.png",
                    Price = 250.00M,
                    Category = "Computers"

                },
                new Product
                {
                    Name = "IPhone",
                    Summary = "Birincisi Sınıf Teleefon",
                    Description = "Al bu kirazdan Kalmaz Birazdan",
                    ImageFile = "iphone.png",
                    Price = 399.00M,
                    Category = "Smart Phone"

                },
                new Product
                {
                    Name = "Logitech Keyboard",
                    Summary = "Birincisi Sınıf Klavye",
                    Description = "Al bu kirazdan Kalmaz Birazdan",
                    ImageFile = "keyboard.png",
                    Price = 320.00M,
                    Category = "Keyboards"

                },
        };
        }
    }
}
