using Ahbc.Class.FiftyFour.Models;
using System.Data.Entity;

namespace Ahbc.Class.FiftyFour.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext() : base("CarContext")
        {
            Database.SetInitializer(new CarDbInitializer());
        }

        public DbSet<Car> Cars { get; set; }
    }
}