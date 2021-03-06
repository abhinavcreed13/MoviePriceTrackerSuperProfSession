﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http.Results;
using System.Web.SessionState;

namespace MoviePriceTrackerRestAPI.Helpers
{
    public static class URLBuilder
    {
        public static string baseURL = ConfigurationManager.AppSettings["movieDBApiBaseUrl"].ToString();
        public static string apiKey = ConfigurationManager.AppSettings["movieDBApiKey"].ToString();

        public static string GetMovieDetailsURL(int movieId)
        {
            var detailsUrl = ConfigurationManager.AppSettings["movieDetailsWithId"].ToString();
            detailsUrl = string.Format(detailsUrl, movieId.ToString());
            detailsUrl = string.Format(baseURL, detailsUrl, apiKey);

            return detailsUrl;
        }

        public static string GetFullPosterPath(string url)
        {
            var baseUrl = ConfigurationManager.AppSettings["movieDBposterPathBaseUrl"].ToString();
            return string.Format(baseUrl, url);
        }

        public static string GetMovieSearchUrl(string keyword)
        {
            var searchUrl = ConfigurationManager.AppSettings["movieSearchUrl"].ToString();
            searchUrl = string.Format(baseURL, searchUrl, apiKey);
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString.Add("query", keyword);
            searchUrl += "&" + queryString.ToString();
            return searchUrl;
        }
    }
}