using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashColllector.Models;



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
