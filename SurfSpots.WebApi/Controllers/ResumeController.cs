﻿using SurfSpots.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SurfSpots.WebApi.Controllers
{
    public class ResumeController : ApiController
    {
        // GET: api/Resume
        [EnableCorsAttribute("http://localhost:1871,http://mb-me.azurewebsites.net,http://mikebolanos.me", "*", "*")]
        public IEnumerable<Resume> Get()
        {
            var resumeRepository = new ResumeRepository();
            return resumeRepository.Retrieve();
        }

        // GET: api/Resume/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Resume
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Resume/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Resume/5
        public void Delete(int id)
        {
        }
    }
}
