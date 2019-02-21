using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ahbc.SampleLab.eCommerce.Models;

namespace Ahbc.SampleLab.eCommerce.Services
{
    public interface IProductService : IDisposable
    {
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(int id);
        Task UpdateInventory(Inventory inventory);
    }
}