using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPDF.Startup))]
namespace WebPDF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
