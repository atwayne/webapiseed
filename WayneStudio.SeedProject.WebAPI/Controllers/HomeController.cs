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

        [HttpGet]
        [Route("home/{productName}/value")]
        public HttpResponseMessage GetValueByProductName(string productName)
        {
            return Request.CreateResponse(HttpStatusCode.OK, productName.ToUpper());
        }
    }
}