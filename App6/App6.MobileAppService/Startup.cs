using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(App6.MobileAppService.Startup))]

namespace App6.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}