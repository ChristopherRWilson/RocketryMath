using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RocketryMath.Startup))]
namespace RocketryMath
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
