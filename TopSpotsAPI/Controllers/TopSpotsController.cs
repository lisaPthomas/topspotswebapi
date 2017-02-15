using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        //IEnumerable means it can be an array or collection of objects(multiple rows)
        public IEnumerable<TopSpot> Get()
        {
       
           return JsonConvert.DeserializeObject<List<TopSpot>>(File.ReadAllText(@"C:\Users\Lisa\Documents\dev\15-TopSpotsAPI\TopSpotsAPI\TopSpotsAPI\App_Start\TopSpotsJSON.json"));
                                        
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
