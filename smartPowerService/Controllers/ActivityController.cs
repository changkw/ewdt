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
            CurrentActivity currentActivity = db.CurrentActivities.OrderByDescending(x => x.timeDate).First();
            if (currentActivity.lighting == 0 && currentActivity.door == 0 && currentActivity.machine == 0 && currentActivity.alarm == 0)
            {
                return false;
            }

            return true;
        }

    }
}
