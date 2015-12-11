using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NWT_Seminar.Startup))]
namespace NWT_Seminar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);
        }
    }
}
