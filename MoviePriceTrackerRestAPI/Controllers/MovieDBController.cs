using MoviePriceTrackerRestAPI.Helpers;
using MoviePriceTrackerRestAPI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviePriceTrackerRestAPI.Controllers
{
    public class MovieDBController : ApiController
    {
        [Route("api/moviedb")]
        public string Get()
        {
            return "MovieDB Api is running!";
        }

        [Route("api/moviedb/getmoviedetails/{movieId}")]
        public MovieDetails GetMovieDetails(int movieId)
        {
            //string movieDbUrl = "https://api.themoviedb.org/3/movie/{0}?api_key={1}";
            //string apiKey = "";
            //movieDbUrl = String.Format(movieDbUrl, movieId.ToString(), apiKey);

            // httpclient
            //using(var httpClient = new HttpClient())
            //{
            //    var responseTask = httpClient.GetStringAsync(new Uri(movieDbUrl));
            //    responseTask.Wait();

            //    return responseTask.Result;
            //}

            //Restsharp
            return MovieDBWrapper.GetMovieDetails(movieId);
        }
    }
}
