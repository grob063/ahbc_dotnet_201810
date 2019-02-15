using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ahbc.SampleLab.eCommerce.Startup))]
namespace Ahbc.SampleLab.eCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
