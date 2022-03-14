using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthPrj.Startup))]
namespace AuthPrj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
