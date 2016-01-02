using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarbonSale.Startup))]
namespace CarbonSale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
