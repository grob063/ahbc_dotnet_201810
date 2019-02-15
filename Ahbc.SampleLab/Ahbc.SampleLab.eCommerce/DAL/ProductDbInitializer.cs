using System.Data.Entity;

namespace Ahbc.SampleLab.eCommerce.DAL
{
    public class ProductDbInitializer : CreateDatabaseIfNotExists<ProductDbContext>
    {
    }
}