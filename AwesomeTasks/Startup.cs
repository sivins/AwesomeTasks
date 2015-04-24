using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwesomeTasks.Startup))]
namespace AwesomeTasks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
