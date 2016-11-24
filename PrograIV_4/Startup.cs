using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrograIV_4.Startup))]
namespace PrograIV_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
