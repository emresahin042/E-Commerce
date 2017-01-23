using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Ticaret_MVC.Startup))]
namespace E_Ticaret_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
