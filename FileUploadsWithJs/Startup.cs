using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileUploadsWithJs.Startup))]
namespace FileUploadsWithJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
