using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTrakrModels;

namespace TripTrakrWebMVC.Controllers
{
    [Authorize]
    public class PersonController : Controller
    {
        // GET: Person List
        public ActionResult Index()
        {
            var model = new PersonListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}