using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Fifty.Cmd
{
    public enum Sex
    {
        Male,
        Female
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
    }

    public class Employee
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>
            {
                new Person{FirstName = "John", LastName = "Smith"},
                new Person{FirstName = "George", LastName = "Bush"},
                new Person{FirstName = "Bill", LastName = "Clinton"},
                new Person{FirstName = "Jimmy", LastName = "Carter"},
                new Person{FirstName = "Ronald", LastName = "Reagan"},
                new Person{FirstName = "Gerold", LastName = "Ford"},
            };

            //// Where returns another "collection" of IEnumerable
            //var test = list.Where(x => x.LastName == "Ford2");
            //var test = list.Where(x => x.LastName == "Ford2").ToList();

            //// First returns the first match
            //var test = list.First(x => x.LastName == "Ford2");
            //var test = list.FirstOrDefault(x => x.LastName == "Ford2");

            //// Last returns the last match
            //var test = list.Last(x => x.LastName == "Ford2");
            //var test = list.LastOrDefault(x => x.LastName == "Ford2");

            //// Returns a single instance, throws otherwise
            //var test = list.Single(x => x.LastName == "Ford2");
            //var test = list.SingleOrDefault(x => x.LastName == "Ford2");

            // Select allows us to create a new IEnumerable of a new type
            //var test = list.Select(x => new Employee { First = x.FirstName, Last = x.LastName })
            //               .FirstOrDefault(x => x.Last == "Ford");

            //// Select we can also return a dynamic types
            //var test = list.Select(x => new { First23 = x.FirstName, Last32 = x.LastName })
            //               .FirstOrDefault(x => x.Last32 == "Ford");

            //// Kristy's question
            //var males = list.Where(x => x.Sex == Sex.Male);
            //var females = list.Where(x => x.Sex == Sex.Female);

            //// Any returns a boolean if a the condition is met
            //list.Any(x => x.Sex == Sex.Female);

            //// Query syntax where and select
            //var test = from x in list
            //           where x.LastName == "Ford"
            //           select new Employee { First = x.FirstName, Last = x.LastName };

            //// To return the same type
            //var test = from x in list
            //           where x.LastName == "Ford"
            //           select x;

            //// And you can combine the two
            //var test = (from x in list
            //           where x.LastName == "Ford"
            //           select x).Take(100);

            Console.ReadKey();
        }
    }
}
