using Project1.Models;
using Project1.Repistroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project1.Controllers
{
    public class ProjectController : ApiController
    {
        public readonly IProject Pro;

        public ProjectController(IProject Pro)
        {
            this.Pro = Pro;
        }

        [Route("api/Project/updateteam")]
        [HttpPost]

        public IHttpActionResult Updateteam(EmpModel on)
        {
            var ser = Pro.Updateteam(on);
            return Ok(ser);
        }

        [Route("api/Project/Getdatajoins")]
        [HttpGet]
        public IHttpActionResult Getdatajoins()
        {
            var ser = Pro.Getdatajoin();
            return Ok(ser);
        }

        [Route("api/Project/Getteam")]
        [HttpGet]

        public IHttpActionResult Getteam()
        {
            var ser = Pro.Getdatajoin();
            return Ok(ser);
        }
    }
}   

