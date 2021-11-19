using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrjWebAppMVC.Startup))]
namespace PrjWebAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
