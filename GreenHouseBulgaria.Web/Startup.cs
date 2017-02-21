using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenHouseBulgaria.Web.Startup))]
namespace GreenHouseBulgaria.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
