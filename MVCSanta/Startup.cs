using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSanta.Startup))]
namespace MVCSanta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
