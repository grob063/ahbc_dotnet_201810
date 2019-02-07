using Ahbc.Class.FiftyThree.Models;
using System.Web.Http;

namespace Ahbc.Class.FiftyThree.Controllers
{
    public class CarsController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            // Retrieve from database
            return Ok(new Car { Vin = "ABC123411234" });
        }

        public IHttpActionResult Post([FromBody]Car car)
        {
            // Save to database
            return Created("/api/cars/1", car);
        }
    }
}
