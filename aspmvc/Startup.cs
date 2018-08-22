using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspmvc.Startup))]
namespace aspmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
