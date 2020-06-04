using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTrakrModels;

namespace TripTrakrWebMVC.Controllers
{
    [Authorize]
    public class TripController : Controller
    {
        // GET: Trip Index
        public ActionResult Index()
        {
            var model = new TripListItem[0];
            return View(model);
        }

        //GET: Trip Create
        public ActionResult Create()
        {
            return View();
        }

        //POST : Trip Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TripCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}