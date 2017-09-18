using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FYPSystem.Startup))]
namespace FYPSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
