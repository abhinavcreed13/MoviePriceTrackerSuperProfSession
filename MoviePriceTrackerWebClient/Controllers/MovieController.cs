using MoviePriceTrackerWebClient.Helpers;
using MoviePriceTrackerWebClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviePriceTrackerWebClient.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            // hit my details api
            string baseUrl = CustomConfigs.MovieBaseUrl;
            string searchUrl = CustomConfigs.SearchUrl;
            searchUrl = string.Format(baseUrl, searchUrl.ToString());

            var client = new RestClient(searchUrl);
            var request = new RestRequest(Method.POST);

            // kind of json (object format)
            var data = new
            {
                query = "Jack Reacher"
            };

            request.AddJsonBody(data);

            var viewModel = client.Execute<MovieSearchModel>(request);

            return View(viewModel.Data.Results);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            // hit my details api
            string baseUrl = CustomConfigs.MovieBaseUrl;
            string movieDetailsURL = CustomConfigs.DetailsUrl;
            movieDetailsURL = string.Format(movieDetailsURL, id.ToString());
            movieDetailsURL = string.Format(baseUrl, movieDetailsURL);

            var client = new RestClient(movieDetailsURL);

            // GET request
            var viewModel = client.Execute<MovieDetailsViewModel>(new RestRequest());

            return View(viewModel.Data);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
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

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
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

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
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
