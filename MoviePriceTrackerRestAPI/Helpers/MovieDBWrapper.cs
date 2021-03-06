﻿using MoviePriceTrackerRestAPI.Models;
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

            var data = response.Data;

            data.PosterPath = URLBuilder.GetFullPosterPath(data.PosterPath);

            return response.Data;
        }

        public static MovieSearch SearchMovie(string keyword)
        {
            var client = new RestClient(URLBuilder.GetMovieSearchUrl(keyword));

            var response = client.Execute<MovieSearch>(new RestRequest());

            var data = response.Data;

            foreach (MovieDetails d in data.Results)
            {
                d.PosterPath = URLBuilder.GetFullPosterPath(d.PosterPath);
            }

            return data;
        }
    }
}