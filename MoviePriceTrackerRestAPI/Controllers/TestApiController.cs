using MoviePriceTrackerRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviePriceTrackerRestAPI.Controllers
{
    public class TestApiController : ApiController
    {
        public string Get()
        {
            return "My TestApi is running!!";
        }

        public List<CustomListItem> GetMyItems()
        {
            List<CustomListItem> items = new List<CustomListItem>
            {
                new CustomListItem { Id = 1, Text = "text1" },
                new CustomListItem { Id = 2, Text = "text2" },
                new CustomListItem { Id = 3, Text = "text3" },
                new CustomListItem { Id = 4, Text = "text4" },
                new CustomListItem { Id = 5, Text = "text5" }
            };
            return items;
        }
    }
}
