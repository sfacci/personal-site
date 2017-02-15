using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sarah.Startup))]
namespace Sarah
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
