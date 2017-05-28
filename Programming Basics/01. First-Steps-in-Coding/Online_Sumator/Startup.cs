using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Sumator.Startup))]
namespace Online_Sumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
