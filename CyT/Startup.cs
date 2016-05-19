using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CyT.Startup))]
namespace CyT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
