using SurfSpots.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData;

namespace SurfSpots.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:16751", "*", "*")]
    public class SurfSpotsController : ApiController
    {
        // GET: api/SurfSpots
        [EnableQuery()]
        public IQueryable<SurfSpot> Get()
        {
            var surfSpotRepository = new SurfSpotRepository();
            return surfSpotRepository.Retrieve().AsQueryable();
        }

        // GET: api/SurfSpots/beacons
        public IEnumerable<SurfSpot> Get(string search)
        {
            var surfSpotRepository = new SurfSpotRepository();
            var surfSpots = surfSpotRepository.Retrieve();
            return surfSpots.Where(s => s.Location.ToLower().Contains(search));
        }

        // GET: api/SurfSpots/5
        public SurfSpot Get(int id)
        {
            SurfSpot spot;
            var surfSpotRepository = new SurfSpotRepository();

            if (id > 0)
            {
                var surfSpots = surfSpotRepository.Retrieve();
                spot = surfSpots.FirstOrDefault(s => s.SpotId == id);
            }
            else
            {
                spot = surfSpotRepository.Create();
            }

            return spot;
        }

        // POST: api/SurfSpots
        public void Post([FromBody]SurfSpot spot)
        {
            var surfSpotRepository = new SurfSpotRepository();
            var newSpot = surfSpotRepository.Save(spot);
        }

        // PUT: api/SurfSpots/5
        public void Put(int id, [FromBody]SurfSpot spot)
        {
            var surfSpotRepository = new SurfSpotRepository();
            var updatedSpot = surfSpotRepository.Save(id, spot);
        }

        // DELETE: api/SurfSpots/5
        public void Delete(int id)
        {
        }
    }
}
