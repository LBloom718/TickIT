using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TickIT.Startup))]
namespace TickIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
