using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Blinds.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Index()
        {
            var response = new HttpResponseMessage
            {
                Content = new StringContent("<html><body><h1>Welcome to code challenge!</h1></body></html>")
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
