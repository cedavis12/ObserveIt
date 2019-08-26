using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObserveIt.Startup))]
namespace ObserveIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
