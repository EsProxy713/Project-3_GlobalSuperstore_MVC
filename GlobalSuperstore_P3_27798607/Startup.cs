using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalSuperstore_P3_27798607.Startup))]
namespace GlobalSuperstore_P3_27798607
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
