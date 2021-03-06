﻿using Microsoft.AspNet.Identity;
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
    public class CountryController : Controller
    {
        // GET: Country Index
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CountryService(userId);

            var model = service.GetCountries();

            return View(model);
        }

        //GET: Country Create
        public ActionResult Create()
        {
            return View();
        }

        //POST : Country Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CountryCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateCountryService();

            if (service.CreateCountry(model))
            {
                TempData["SaveResult"] = "Country was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Country could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateCountryService();
            var model = svc.GetCountryById(id);

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var service = CreateCountryService();
            var detail = service.GetCountryById(id);
            var model =
                new CountryEdit
                {
                    CountryId = detail.CountryId,
                    CountryName = detail.CountryName,
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CountryEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CountryId != id)
            {
                ModelState.AddModelError("", "ID Mismatch");
                return View(model);
            }

            var service = CreateCountryService();

            if (service.UpdateCountry(model))
            {
                TempData["SaveResult"] = "The country was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The country could not be updated.");
            return View(model);
        }



        private CountryService CreateCountryService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CountryService(userId);
            return service;
        }
    }
}