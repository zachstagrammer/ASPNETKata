using ASPNETKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETKata.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            var list = new List<Person>();

            list.Add(new Person { Name = "Dirty Harry", Age = 14, IsMinor = true });
            list.Add(new Person { Name = "Vito Corleone", Age = 18, IsMinor = false });
            list.Add(new Person { Name = "Jules Winnfield", Age = 17, IsMinor = true });
            list.Add(new Person { Name = "Nicky Santoro", Age = 54, IsMinor = false });
            list.Add(new Person { Name = "Larry Dimmick", Age = 21, IsMinor = false });
            list.Add(new Person { Name = "John Dillinger", Age = 29, IsMinor = false });
            list.Add(new Person { Name = "Henry Hill", Age = 17, IsMinor = true });
            list.Add(new Person { Name = "Vincent Vega", Age = 48, IsMinor = false });
            list.Add(new Person { Name = "Al Pacino", Age = 18, IsMinor = false });
            list.Add(new Person { Name = "Tony Montana", Age = 19, IsMinor = false });
            
            return View(list);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
