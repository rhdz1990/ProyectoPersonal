using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProyectoPersonal.Startup))]
namespace WebAppProyectoPersonal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
