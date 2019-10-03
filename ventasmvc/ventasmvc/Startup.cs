using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ventasmvc.Startup))]
namespace ventasmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
