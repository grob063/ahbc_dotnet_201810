using Ahbc.Class.FiftyFour.Data;
using Ahbc.Class.FiftyFour.Models;
using System.Web.Http;

namespace Ahbc.Class.FiftyFour.Controllers.Api
{
    public class CarsController : ApiController
    {
        private CarDbContext _context = new CarDbContext();

        public IHttpActionResult Post([FromBody]Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return Created($"/api/cars/{car.ID}", car);
        }
    }
}
