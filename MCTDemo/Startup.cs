using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCTDemo.Startup))]
namespace MCTDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
