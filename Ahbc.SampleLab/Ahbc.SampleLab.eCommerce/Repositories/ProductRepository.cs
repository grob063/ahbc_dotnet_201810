using Ahbc.SampleLab.eCommerce.DAL;
using Ahbc.SampleLab.eCommerce.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Ahbc.SampleLab.eCommerce.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductDbContext db = new ProductDbContext();

        public async Task<Product> Get(int id)
        {
            return await db.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await db.Products.ToListAsync();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}