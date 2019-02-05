using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ahbc.Class.FiftyTwo.Startup))]
namespace Ahbc.Class.FiftyTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
