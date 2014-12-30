using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityWebAppNew.Startup))]
namespace UniversityWebAppNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
