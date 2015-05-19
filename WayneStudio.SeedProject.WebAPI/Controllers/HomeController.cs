using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WayneStudio.SeedProject.WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Index()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "hello world");
        }
    }
}