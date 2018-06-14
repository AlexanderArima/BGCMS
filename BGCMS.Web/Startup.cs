using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BGCMS.Web.Startup))]
namespace BGCMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
