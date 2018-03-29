using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(drzewo.Startup))]
namespace drzewo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
