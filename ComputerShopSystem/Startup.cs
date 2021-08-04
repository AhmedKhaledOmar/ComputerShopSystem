using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComputerShopSystem.Startup))]
namespace ComputerShopSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
