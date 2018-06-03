using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMPS285_Project.Startup))]
namespace CMPS285_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
