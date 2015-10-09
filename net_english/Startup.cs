using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(net_english.Startup))]
namespace net_english
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
