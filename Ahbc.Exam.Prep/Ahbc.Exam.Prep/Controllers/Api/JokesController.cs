using Ahbc.Exam.Prep.Models;
using System.Web.Http;

namespace Ahbc.Exam.Prep.Controllers.Api
{
    public class JokesController : ApiController
    {
        public Joke Get()
        {
            return new Joke() { Value = "Why did the chicken cross the road? Chuck Norris!" };
        }
    }
}
