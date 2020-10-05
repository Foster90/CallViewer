using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CallViewer.Startup))]
namespace CallViewer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
