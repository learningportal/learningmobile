using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningMobile.UI.Startup))]
namespace LearningMobile.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
