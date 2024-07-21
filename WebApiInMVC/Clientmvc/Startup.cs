using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clientmvc.Startup))]
namespace Clientmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
