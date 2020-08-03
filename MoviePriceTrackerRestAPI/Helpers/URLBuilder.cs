using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
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
    }
}