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

        public ActionResult Details(int id)
        {
            var svc = CreatePersonService();
            var model = svc.GetPersonById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePersonService();
            var detail = service.GetPersonById(id);
            var model =
                new PersonEdit
                {
                    PersonId = detail.PersonId,
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    HowKnown = detail.HowKnown
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.PersonId != id)
            {
                ModelState.AddModelError("", "ID Mismatch");
                return View(model);
            }

            var service = CreatePersonService();

            if (service.UpdatePerson(model))
            {
                TempData["SaveResult"] = "The person was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The person could not be updated.");
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