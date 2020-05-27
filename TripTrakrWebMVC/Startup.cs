using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TripTrakrWebMVC.Startup))]
namespace TripTrakrWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
