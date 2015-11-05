using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfSpots.WebApi.Models
{
    public class SpotForecast
    {
        public string Hour { get; set; }
        public int Size { get; set; }
        public string Shape_full { get; set; }
        public ShapeDetail Shape_detail { get; set; }
    }

    public class ShapeDetail
    {
        public string Swell { get; set; }
        public string Tide { get; set; }
        public string Wind { get; set; }
    }
}