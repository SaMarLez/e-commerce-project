using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoltShop.Startup))]
namespace VoltShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
