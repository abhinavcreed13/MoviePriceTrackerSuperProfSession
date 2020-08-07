using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviePriceTrackerRestAPI.Models
{
    public class MovieSearch
    {
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public List<MovieDetails> Results { get; set; }
    }

    public class MovieSearchParameter
    {
        public string Query { get; set; }
    }
}