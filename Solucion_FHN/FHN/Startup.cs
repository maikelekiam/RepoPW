using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FHN.Startup))]
namespace FHN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
