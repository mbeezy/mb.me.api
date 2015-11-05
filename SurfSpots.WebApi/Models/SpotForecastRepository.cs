using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SurfSpots.WebApi.Models
{
    public class SpotForecastRepository
    {
        readonly string baseUri = "http://api.spitcast.com/api/spot/forecast/";

        internal async Task<List<SpotForecast>> GetSpotForecastById(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<SpotForecast>>(await client.GetStringAsync(baseUri + id.ToString() + "/"));
            }
        }
    }
}