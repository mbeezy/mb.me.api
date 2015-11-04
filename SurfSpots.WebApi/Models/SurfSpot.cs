using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfSpots.WebApi.Models
{
    public class SurfSpot
    {
        public int SpotId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}