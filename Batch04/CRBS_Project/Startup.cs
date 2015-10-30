using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRBS_Project.Startup))]
namespace CRBS_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
