using System.Data.Entity;

namespace Ahbc.SampleLab.Inventory.DAL
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext() : base("InventoryContext")
        {
            Database.SetInitializer(new InventoryDbInitializer());
        }

        public DbSet<Models.Inventory> Inventories { get; set; }
    }
}