using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthAndFitness.Startup))]
namespace HealthAndFitness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
