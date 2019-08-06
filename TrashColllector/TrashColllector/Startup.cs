using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashColllector.Startup))]
namespace TrashColllector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
