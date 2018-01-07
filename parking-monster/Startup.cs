using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(parking_monster.Startup))]
namespace parking_monster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
