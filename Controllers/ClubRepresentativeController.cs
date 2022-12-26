using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M3gogo.Controllers
{
    public class ClubRepresentativeController : Controller
    {
        // GET: ClubRepresentative
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClubRepresentative/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClubRepresentative/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClubRepresentative/Create
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

        // GET: ClubRepresentative/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClubRepresentative/Edit/5
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

        // GET: ClubRepresentative/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClubRepresentative/Delete/5
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

        public ActionResult getClub()
        {
            return View();
        }
    }
}
