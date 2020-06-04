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
        // GET: Country Index
        public ActionResult Index()
        {
            var model = new CountryListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}