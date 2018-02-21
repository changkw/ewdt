using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using smartPowerService.Models;

namespace smartPowerService.Controllers
{
    public class CurrentActivitiesController : ApiController
    {
        private smartPowerServiceContext db = new smartPowerServiceContext();

        // GET: api/CurrentActivities
        public IQueryable<CurrentActivity> GetCurrentActivities()
        {
            return db.CurrentActivities;
        }

        // GET: api/CurrentActivities/5
        [ResponseType(typeof(CurrentActivity))]
        public async Task<IHttpActionResult> GetCurrentActivity(int id)
        {
            CurrentActivity currentActivity = await db.CurrentActivities.FindAsync(id);
            if (currentActivity == null)
            {
                return NotFound();
            }

            return Ok(currentActivity);
        }

        // PUT: api/CurrentActivities/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCurrentActivity(int id, CurrentActivity currentActivity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != currentActivity.CurrentActivityId)
            {
                return BadRequest();
            }

            db.Entry(currentActivity).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrentActivityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CurrentActivities
        [ResponseType(typeof(CurrentActivity))]
        public async Task<IHttpActionResult> PostCurrentActivity(CurrentActivity currentActivity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CurrentActivities.Add(currentActivity);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = currentActivity.CurrentActivityId }, currentActivity);
        }

        // DELETE: api/CurrentActivities/5
        [ResponseType(typeof(CurrentActivity))]
        public async Task<IHttpActionResult> DeleteCurrentActivity(int id)
        {
            CurrentActivity currentActivity = await db.CurrentActivities.FindAsync(id);
            if (currentActivity == null)
            {
                return NotFound();
            }

            db.CurrentActivities.Remove(currentActivity);
            await db.SaveChangesAsync();

            return Ok(currentActivity);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CurrentActivityExists(int id)
        {
            return db.CurrentActivities.Count(e => e.CurrentActivityId == id) > 0;
        }





    }
}