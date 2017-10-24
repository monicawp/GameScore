using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameScore.Startup))]
namespace GameScore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
