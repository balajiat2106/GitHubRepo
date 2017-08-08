using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubInfo.Web.Startup))]
namespace GitHubInfo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
