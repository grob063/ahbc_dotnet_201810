using Ahbc.SampleLab.eCommerce.DAL;
using Ahbc.SampleLab.eCommerce.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using Ahbc.SampleLab.eCommerce.Repositories;

namespace Ahbc.SampleLab.eCommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> Get()
        {
            // Business Logic Here
            return await _repository.Get();
        }

        public async Task<Product> Get(int id)
        {
            return await _repository.Get(id);
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
            _repository.Dispose();
        }
    }
}