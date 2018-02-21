using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using smartPowerService.Models;

namespace smartPowerService.Controllers
{
    public class WorksController : ApiController
    {
        private smartPowerServiceContext db = new smartPowerServiceContext();

        // GET: api/Works
        public IQueryable<Work> GetWorks()
        {
            return db.Works;
        }

        // GET: api/Works/5
        [ResponseType(typeof(Work))]
        public IHttpActionResult GetWork(string id)
        {
            Work work = db.Works.Find(id);
            if (work == null)
            {
                return NotFound();
            }

            return Ok(work);
        }

        // PUT: api/Works/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWork(int id, Work work)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != work.workID)
            {
                return BadRequest();
            }

            db.Entry(work).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkExists(id))
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

        // POST: api/Works
        [ResponseType(typeof(Work))]
        public IHttpActionResult PostWork(Work work)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Works.Add(work);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WorkExists(work.workID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = work.workID }, work);
        }

        // DELETE: api/Works/5
        [ResponseType(typeof(Work))]
        public IHttpActionResult DeleteWork(string id)
        {
            Work work = db.Works.Find(id);
            if (work == null)
            {
                return NotFound();
            }

            db.Works.Remove(work);
            db.SaveChanges();

            return Ok(work);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WorkExists(int id)
        {
            return db.Works.Count(e => e.workID == id) > 0;
        }
    }
}