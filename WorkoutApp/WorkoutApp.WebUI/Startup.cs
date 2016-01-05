using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkoutApp.WebUI.Startup))]
namespace WorkoutApp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
