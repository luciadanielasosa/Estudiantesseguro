using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admstudentseccure.Startup))]
namespace admstudentseccure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
