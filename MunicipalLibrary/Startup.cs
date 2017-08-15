using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MunicipalLibrary.Startup))]
namespace MunicipalLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
