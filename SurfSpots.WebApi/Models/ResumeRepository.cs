using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace SurfSpots.WebApi.Models
{
    public class ResumeRepository
    {
        internal Resume Create()
        {
            var resume = new Resume() { };
            return resume;
        }

        internal List<Resume> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/resume.json");
            var json = System.IO.File.ReadAllText(filePath);
            var resume = JsonConvert.DeserializeObject<List<Resume>>(json);
            return resume;
        }
    }
}