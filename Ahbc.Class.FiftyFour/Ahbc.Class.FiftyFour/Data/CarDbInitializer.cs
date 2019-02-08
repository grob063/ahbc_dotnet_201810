using System.Data.Entity;

namespace Ahbc.Class.FiftyFour.Data
{
    public class CarDbInitializer : CreateDatabaseIfNotExists<CarDbContext>
    {
    }
}