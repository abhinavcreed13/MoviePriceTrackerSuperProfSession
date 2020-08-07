using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviePriceTrackerWebClient.Models
{
    public class MovieSearchModel
    {
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public List<MovieDetailsViewModel> Results { get; set; }
    }
}