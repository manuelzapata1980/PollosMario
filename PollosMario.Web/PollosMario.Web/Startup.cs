using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PollosMario.Web.Startup))]
namespace PollosMario.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
