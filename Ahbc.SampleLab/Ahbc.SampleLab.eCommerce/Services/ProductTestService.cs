using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Ahbc.SampleLab.eCommerce.Models;

namespace Ahbc.SampleLab.eCommerce.Services
{
    public class ProductTestService : IProductService
    {
        public Task<IEnumerable<Product>> Get()
        {
            return Task.FromResult(new List<Product>
            {
                new Product{ Id = 9, ItemId = 9, Name = "Small Coffee", Description = "Coffee", Price = 2}
            } as IEnumerable<Product>);
        }

        public Task<Product> Get(int id)
        {
            return Task.FromResult(new Product { Id = 9, ItemId = 9, Name = "Small Coffee", Description = "Coffee", Price = 2 });
        }

        public Task UpdateInventory(Inventory inventory)
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            
        }
    }
}