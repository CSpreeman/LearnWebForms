using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnWebForms.Startup))]
namespace LearnWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
