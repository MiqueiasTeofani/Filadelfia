using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filadelfia.Startup))]
namespace Filadelfia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
