using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admstudentseccure2.Startup))]
namespace admstudentseccure2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
