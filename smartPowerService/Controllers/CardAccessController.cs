// BY: Chang Kai Wen
using smartPowerService.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace smartPowerService.Controllers
{
    public class CardAccessController : ApiController
    {
        private smartPowerServiceContext db = new smartPowerServiceContext();

        // POST API to create a Work record with start time and user ID
        public IHttpActionResult Post([FromUri] int userid)
        {
            var work = new Work { userID = userid, startTime = DateTime.Now };
            db.Works.Add(work);
            db.SaveChanges();
            return Ok();
        }

        // PUT API to set the end time for a user ID
        public IHttpActionResult Put([FromUri] int userid)
        {
            var work = db.Works.Where(x => x.userID == userid && x.endTime == null).FirstOrDefault<Work>();
            work.endTime = DateTime.Now;
            db.SaveChanges();
            return Ok();
        }

    }
}
