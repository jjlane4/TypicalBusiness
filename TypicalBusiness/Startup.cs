using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TypicalBusiness.Startup))]
namespace TypicalBusiness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
