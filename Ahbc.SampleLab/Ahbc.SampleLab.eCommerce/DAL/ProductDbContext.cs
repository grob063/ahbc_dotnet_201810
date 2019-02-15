using Ahbc.SampleLab.eCommerce.Models;
using System.Data.Entity;

namespace Ahbc.SampleLab.eCommerce.DAL
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProductContext")
        {
            Database.SetInitializer(new ProductDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }
}