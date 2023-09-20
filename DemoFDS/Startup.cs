using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoFDS.Startup))]
namespace DemoFDS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
