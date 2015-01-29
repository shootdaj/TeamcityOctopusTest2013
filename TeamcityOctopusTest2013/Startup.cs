using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamcityOctopusTest2013.Startup))]
namespace TeamcityOctopusTest2013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
