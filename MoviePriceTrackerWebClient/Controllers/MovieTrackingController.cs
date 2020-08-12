using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviePriceTrackerWebClient.Controllers
{
    public class MovieTrackingController : Controller
    {
        // storage on server side
        public static List<int> TrackingMovieIds = new List<int>();

        // GET: MovieTracking
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieTracking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieTracking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieTracking/Create
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

        // GET: MovieTracking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieTracking/Edit/5
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

        // GET: MovieTracking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieTracking/Delete/5
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
