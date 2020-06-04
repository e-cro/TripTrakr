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
    public class PersonController : Controller
    {
        // GET: Person List
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PersonService(userId);

            var model = service.GetPeople();

            return View(model);
        }

        //GET : Person Create
        public ActionResult Create()
        {
            return View();
        }

        //POST : Person Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            
            var service = CreatePersonService();

            if (service.CreatePerson(model))
            {
                TempData["SaveResult"] = "Person was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Person could not be created.");

            return View(model);

        }

        private PersonService CreatePersonService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PersonService(userId);
            return service;
        }
    }
}