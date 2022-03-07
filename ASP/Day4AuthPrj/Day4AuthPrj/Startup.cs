using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day4AuthPrj.Startup))]
namespace Day4AuthPrj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
