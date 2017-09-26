using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAutomovel.Startup))]
namespace WebAppAutomovel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
