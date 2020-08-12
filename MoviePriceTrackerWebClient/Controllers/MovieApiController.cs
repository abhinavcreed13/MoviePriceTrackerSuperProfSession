using MoviePriceTrackerWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviePriceTrackerWebClient.Controllers
{
    public class MovieApiController : ApiController
    {
        public string Get()
        {
            return "MovieApi is hosted!!";
        }

        [HttpPost]
        [Route("api/movieapi/trackmovie")]
        public object TrackMovie(MovieParameters parameters)
        {
            MovieTrackingController.TrackingMovieIds.Add(parameters.MovieId);
            // smart way to create json
            return new
            {
                message = "Tracking movie: " + parameters.MovieId.ToString()
            };
        }

        [HttpPost]
        [Route("api/movieapi/removetracking")]
        public object RemoveTracking(MovieParameters parameters)
        {
            MovieTrackingController.TrackingMovieIds.Remove(parameters.MovieId);
            // smart way to create json
            return new
            {
                message = "Removing tracked movie: " + parameters.MovieId.ToString()
            };
        }
    }
}
