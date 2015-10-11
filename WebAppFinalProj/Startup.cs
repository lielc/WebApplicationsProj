using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppFinalProj.Startup))]
namespace WebAppFinalProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
