using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rest_Api.Controllers
{
    public class PictureApiController : Controller
    {
        // GET: PictureApi
        public ActionResult Index()
        {
            return View();
        }
    }
}