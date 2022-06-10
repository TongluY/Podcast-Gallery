using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace PodcastGallery.Controllers
{
    public class PodcastsController : Controller
    {
        public ActionResult Detail()
        {
            return View();
        }
    }
}
