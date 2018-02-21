using smartPowerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace smartPowerService.Controllers
{
    public class PresenceController : ApiController
    {
        private smartPowerServiceContext db = new smartPowerServiceContext();
        // GET: api/Presence
        public Boolean Get()
        {
            IEnumerable<Work> works = db.Works.AsEnumerable();
            foreach (var w in works)
            {
                if (w.endTime == null)
                {
                    return true;
                }
            }
            return false;
        }

 
    }
}
