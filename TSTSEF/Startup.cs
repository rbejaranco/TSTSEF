using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSTSEF.Startup))]
namespace TSTSEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
