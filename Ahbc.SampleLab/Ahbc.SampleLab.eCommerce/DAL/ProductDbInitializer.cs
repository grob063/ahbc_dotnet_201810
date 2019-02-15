using Ahbc.SampleLab.eCommerce.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Ahbc.SampleLab.eCommerce.DAL
{
    public class ProductDbInitializer : CreateDatabaseIfNotExists<ProductDbContext>
    {
        protected override void Seed(ProductDbContext context)
        {
            var products = new List<Product>
            {
                new Product { ItemId = 1, Name = "White T-Shirt", Description = "A cozy shirt without tags", Price = 5.00 },
                new Product { ItemId = 2, Name = "Socks", Description = "Ankle socks", Price = 5.00 },
                new Product { ItemId = 3, Name = "Blue Hat", Description = "The coolest blue hat ever", Price = 15.00 },
                new Product { ItemId = 4, Name = "Skateboard", Description = "Doing kick flips yo", Price = 50.00 },
                new Product { ItemId = 5, Name = "Biker Helmet", Description = "It's got flames", Price = 25.00 },
                new Product { ItemId = 6, Name = "Khaki Dockers", Description = "The pants not the containers", Price = 45.00 },
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}