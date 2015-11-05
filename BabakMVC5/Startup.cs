using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BabakMVC5.Startup))]
namespace BabakMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
