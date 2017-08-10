using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RawEpsilonVms.Startup))]
namespace RawEpsilonVms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
