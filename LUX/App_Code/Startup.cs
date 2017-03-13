using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LUX.Startup))]
namespace LUX
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
