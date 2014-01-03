using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcBasedTemplate.Startup))]
namespace MvcBasedTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
