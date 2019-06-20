using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpotifyAppDemo.Startup))]
namespace SpotifyAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
