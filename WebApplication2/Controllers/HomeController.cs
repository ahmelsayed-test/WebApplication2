using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            var header1Value = requestContext.HttpContext.Request.Headers["X-HEADER-1"];
            if (string.IsNullOrEmpty(header1Value))
            {
                var stringBuilder = new StringBuilder();
                // append all headers to stringBuilder
                var errorMessage = string.Format("SiteId header is not set. Headers: {0}", stringBuilder);
                throw new HttpRequestException(errorMessage);
            }

            base.Initialize(requestContext);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}