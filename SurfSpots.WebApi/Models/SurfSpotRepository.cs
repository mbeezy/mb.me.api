using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace SurfSpots.WebApi.Models
{
    public class SurfSpotRepository
    {
        internal SurfSpot Create()
        {
            var surfSpot = new SurfSpot() {  };
            return surfSpot;
        }

        internal List<SurfSpot> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/surfspots.json");
            var json = System.IO.File.ReadAllText(filePath);
            var surfSpots = JsonConvert.DeserializeObject<List<SurfSpot>>(json);
            return surfSpots;
        }

        internal SurfSpot Save(SurfSpot surfSpot)
        {
            var surfSpots = Retrieve();

            var maxId = surfSpots.Max(s => s.SpotId);
            surfSpot.SpotId = maxId + 1;
            surfSpots.Add(surfSpot);

            WriteData(surfSpots);

            return surfSpot;
        }

        internal SurfSpot Save(int id, SurfSpot surfSpot)
        {
            var surfSpots = Retrieve();

            var itemIndex = surfSpots.FindIndex(s => s.SpotId == surfSpot.SpotId);

            if (itemIndex > 0)
            {
                surfSpots[itemIndex] = surfSpot;
            }
            else
            {
                return null;
            }

            WriteData(surfSpots);

            return surfSpot;
        }

        private bool WriteData(List<SurfSpot> surfSpots)
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/surfspots.json");
            var json = JsonConvert.SerializeObject(surfSpots, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);
            return true;
        }
    }
}