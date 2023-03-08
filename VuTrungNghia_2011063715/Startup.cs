using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuTrungNghia_2011063715.Startup))]
namespace VuTrungNghia_2011063715
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
