using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Red03.Startup))]
namespace Red03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
