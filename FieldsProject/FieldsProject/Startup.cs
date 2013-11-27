using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FieldsProject.Startup))]
namespace FieldsProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
