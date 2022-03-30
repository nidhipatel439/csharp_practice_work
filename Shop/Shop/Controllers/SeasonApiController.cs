using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shop.Controllers
{
    
    public class SeasonApiController : ApiController
    {
        [HttpGet]
        [Route("api/Season/Name/{temp}")]

        public string Name(int? temp)
        {
            string season = "";

            if (temp == null) return "unknown";
            if (temp > 20)
            {
                season = "Summer";
            } else if(temp >= 15)
            {
                season = "Fall";
            } else if (temp > 10)
            {
                season = "Spring";
            } else
            {
                season = "Winter";
            }
           // string message = "The season is " + season + ".";
            return season;
        }

    }
}
