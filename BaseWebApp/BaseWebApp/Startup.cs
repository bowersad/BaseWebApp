using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseWebApp.Startup))]
namespace BaseWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
