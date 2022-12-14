using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleASPNetApp.Startup))]
namespace SampleASPNetApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
