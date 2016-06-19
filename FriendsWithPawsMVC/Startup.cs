using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendsWithPawsMVC.Startup))]
namespace FriendsWithPawsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
