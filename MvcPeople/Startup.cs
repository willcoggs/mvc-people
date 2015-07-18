using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPeople.Startup))]
namespace MvcPeople
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
