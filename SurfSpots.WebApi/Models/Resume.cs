using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfSpots.WebApi.Models
{
    public class Resume
    {
        public string Position { get; set; }

        public string Company { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string[] Responsibilities { get; set; }
    }
}