using System;
using System.Linq;
using System.Web.Http;
using smartPowerService.Models;

namespace smartPowerService.Controllers
{
    public class ActivityController : ApiController
    {
        private smartPowerServiceContext db = new smartPowerServiceContext();

        // GET: api/Activity
        public Boolean Get()
        {
            CurrentActivity currentActivity = db.CurrentActivities.OrderByDescending(x => x.Timedate).First();
            if (currentActivity.Lighting == 0 && currentActivity.Door == 0 && currentActivity.Machine == 0 && currentActivity.Alarm == 0)
            {
                return false;
            }

            return true;
        }
        
    } 
}
