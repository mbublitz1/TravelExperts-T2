using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelExperts.Startup))]
namespace TravelExperts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
