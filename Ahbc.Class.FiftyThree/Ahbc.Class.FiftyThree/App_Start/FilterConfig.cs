using System.Web;
using System.Web.Mvc;

namespace Ahbc.Class.FiftyThree
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
