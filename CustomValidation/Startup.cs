using CustomValidation;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace CustomValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
