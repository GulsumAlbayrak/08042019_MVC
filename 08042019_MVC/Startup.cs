using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_08042019_MVC.Startup))]
namespace _08042019_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
