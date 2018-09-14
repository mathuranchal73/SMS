using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMSUI.Startup))]
namespace SMSUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
