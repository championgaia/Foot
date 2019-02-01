using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootbalManager_UIL.Startup))]
namespace FootbalManager_UIL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
