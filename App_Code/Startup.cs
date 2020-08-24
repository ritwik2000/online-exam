using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(makaut.Startup))]
namespace makaut
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
