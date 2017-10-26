using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMobile.Startup))]
namespace WebAppMobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
