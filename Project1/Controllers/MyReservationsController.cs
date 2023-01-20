using Project1.Models;
using Project1.Repistroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Project1.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class MyReservationsController : ApiController
    {

        public readonly IReservations reserDetails;

        public MyReservationsController(IReservations recdetails)
        {
            this.reserDetails = recdetails;
        }


        [Route("api/MyReservationsController/GetMyReservations")]
        [HttpGet]
        public IHttpActionResult GetMyReservations()
        {
            var rer = reserDetails.GetMyReservations();
            if(rer.Count == 0)
            {
                return NotFound();
            }
            return Ok(rer);
        }


        [Route("api/MyReservationsController/Create")]
        [HttpPost]
        public  IHttpActionResult Create(MyReservatonsMode res)
        {
            var re = reserDetails.Create(res);
            if (re != null) {
                return Ok(res);
            }
            return NotFound(); 
            

        }

        [Route("api/MyReservationsController/Edit")]
        [HttpPost]
        public IHttpActionResult Edit(MyReservatonsMode res)
        
        {
            var re = reserDetails.Edit(res);

            return Ok(res);
        }

        [Route("api/MyReservationsController/Delete/{Slno}")]
        [HttpDelete]
        public IHttpActionResult Delete(int Slno)
        {
            var re = reserDetails.Delete(Slno);
            if(re == null)
            {
                return NotFound();
            }
            return Ok(re);
        }


    }
}
