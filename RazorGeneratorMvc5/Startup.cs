using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorGeneratorMvc5.Startup))]
namespace RazorGeneratorMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
