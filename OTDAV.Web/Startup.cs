using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTDAV.Web.Startup))]
namespace OTDAV.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
