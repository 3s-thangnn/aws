using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AWSDemo.Startup))]
namespace AWSDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
