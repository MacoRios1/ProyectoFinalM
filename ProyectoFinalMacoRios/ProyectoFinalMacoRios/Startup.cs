using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoFinalMacoRios.Startup))]
namespace ProyectoFinalMacoRios
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
