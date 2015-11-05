using SurfSpots.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SurfSpots.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:1871,http://mb-me.azurewebsites.net", "*", "*")]
    public class SurfForecastController : ApiController
    {
        // GET: api/SurfForecast/5
        public async Task<List<SpotForecast>> Get(int id)
        {
            var spotForecastRepository = new SpotForecastRepository();
            var results = await spotForecastRepository.GetSpotForecastById(id);
            return results;
        }

        // POST: api/SurfForecast
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SurfForecast/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SurfForecast/5
        public void Delete(int id)
        {
        }
    }
}
