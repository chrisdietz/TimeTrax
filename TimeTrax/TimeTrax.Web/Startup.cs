using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeTrax.Web.Startup))]
namespace TimeTrax.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
