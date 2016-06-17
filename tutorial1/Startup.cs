using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tutorial1.Startup))]
namespace tutorial1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
