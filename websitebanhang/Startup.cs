using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(websitebanhang.Startup))]
namespace websitebanhang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
