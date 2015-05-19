using System.Web;
using System.Web.Http;
using WayneStudio.SeedProject.WebAPI.Core;

namespace WayneStudio.SeedProject.WebAPI
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}