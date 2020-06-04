using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTrakrModels;

namespace TripTrakrWebMVC.Controllers
{
    [Authorize]
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            var model = new CountryListItem[0];
            return View(model);
        }
    }
}