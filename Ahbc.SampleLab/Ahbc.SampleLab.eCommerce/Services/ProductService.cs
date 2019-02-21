using Ahbc.SampleLab.eCommerce.DAL;
using Ahbc.SampleLab.eCommerce.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace Ahbc.SampleLab.eCommerce.Services
{
    public class ProductService : IProductService
    {
        private ProductDbContext db = new ProductDbContext();

        public async Task<IEnumerable<Product>> Get()
        {
            return await db.Products.ToListAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await db.Products.FindAsync(id);
        }

        public async Task UpdateInventory(Inventory inventory)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:65455/");
            var response = await client.PutAsJsonAsync($"api/inventories/{inventory.ID}", inventory);
            response.EnsureSuccessStatusCode();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}