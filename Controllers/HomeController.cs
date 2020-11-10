using MyFirstWebsite.Logic;
using MyFirstWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult testDisplay()
        {
            ViewBag.Message = "Your application description page.";
            var data = dataBaseLogic.showPeople();
            List<modelTest> people = new List<modelTest>();

            foreach(var line in data)
            {
                people.Add(new modelTest
                {
                    Id = line.Id,
                    name = line.name,
                    age = line.age

                });

            }

            return View(people);
        }

        public ActionResult testData()
        {
            ViewBag.Message = "Your Test Data.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult testData(modelTest model)
        {
            if (ModelState.IsValid)
            {
                dataBaseLogic.addPersonToTable(model.name, model.age);
                return RedirectToAction("testDisplay");

            }

            return View();
        }




    }
}