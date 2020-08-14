using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviePriceTrackerRestAPI.Models
{
    public class MovieDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        public int Price { get; set; }

        // constructor
        public MovieDetails()
        {
            Random _random = new Random();
            Price = _random.Next(100); // 1 - 100
        }
    }
}