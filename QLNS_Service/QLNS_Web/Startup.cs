using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLNS_Web.Startup))]
namespace QLNS_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
