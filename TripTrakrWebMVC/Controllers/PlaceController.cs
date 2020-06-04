using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTrakrModels;

namespace TripTrakrWebMVC.Controllers
{
    [Authorize]
    public class PlaceController : Controller
    {
        // GET: Place
        public ActionResult Index()
        {
            var model = new PlaceListItem[0];
            return View(model);
        }
    }
}