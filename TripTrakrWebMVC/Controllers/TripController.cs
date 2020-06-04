using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTrakrModels;
using TripTrakrServices;

namespace TripTrakrWebMVC.Controllers
{
    [Authorize]
    public class TripController : Controller
    {
        // GET: Trip Index
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TripService(userId);

            var model = service.GetTrips();
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
            if (!ModelState.IsValid) return View(model);

            var service = CreateTripService();

            if (service.CreateTrip(model))
            {
                TempData["SaveResult"] = "Trip was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Trip could not be created.");

            return View(model);
        }

        private TripService CreateTripService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TripService(userId);
            return service;
        }
    }
}