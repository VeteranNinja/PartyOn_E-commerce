using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyOn.Startup))]
namespace PartyOn
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
