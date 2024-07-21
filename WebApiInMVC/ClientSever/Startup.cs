using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientSever.Startup))]
namespace ClientSever
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
