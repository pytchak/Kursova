using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kursova.Startup))]
namespace Kursova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
