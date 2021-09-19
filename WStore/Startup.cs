using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WStore.Startup))]
namespace WStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
