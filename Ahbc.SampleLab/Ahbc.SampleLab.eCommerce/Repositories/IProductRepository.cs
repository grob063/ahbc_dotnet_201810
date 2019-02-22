using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ahbc.SampleLab.eCommerce.Models;

namespace Ahbc.SampleLab.eCommerce.Repositories
{
    public interface IProductRepository : IDisposable
    {
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(int id);
    }
}