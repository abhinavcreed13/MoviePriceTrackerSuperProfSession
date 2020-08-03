using MoviePriceTrackerRestAPI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviePriceTrackerRestAPI.Helpers
{
    public static class MovieDBWrapper
    {
        public static MovieDetails GetMovieDetails(int movieId)
        {
            var client = new RestClient(URLBuilder.GetMovieDetailsURL(movieId));

            var response = client.Execute<MovieDetails>(new RestRequest());

            return response.Data;
        }
    }
}