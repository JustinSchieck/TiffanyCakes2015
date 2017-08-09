using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiffanysCakes2015.Startup))]
namespace TiffanysCakes2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
