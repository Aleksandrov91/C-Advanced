using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15.Fruits.Startup))]
namespace _15.Fruits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
