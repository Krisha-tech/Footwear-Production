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
using WebApi.Models;

namespace WebApi.Controllers
{
    public class FootwearController : ApiController
    {
        private DBModels db = new DBModels();

        // GET: api/Footwear
        public IQueryable<Footwear> GetFootwears()
        {
            return db.Footwears;
        }

        // GET: api/Footwear/5
        [ResponseType(typeof(Footwear))]
        public IHttpActionResult GetFootwear(int id)
        {
            Footwear footwear = db.Footwears.Find(id);
            if (footwear == null)
            {
                return NotFound();
            }

            return Ok(footwear);
        }

        // PUT: api/Footwear/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFootwear(int id, Footwear footwear)
        {
            if (id != footwear.FootwearID)
            {
                return BadRequest();
            }

            db.Entry(footwear).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FootwearExists(id))
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

        // POST: api/Footwear
        [ResponseType(typeof(Footwear))]
        public IHttpActionResult PostFootwear(Footwear footwear)
        {
            db.Footwears.Add(footwear);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = footwear.FootwearID }, footwear);
        }

        // DELETE: api/Footwear/5
        [ResponseType(typeof(Footwear))]
        public IHttpActionResult DeleteFootwear(int id)
        {
            Footwear footwear = db.Footwears.Find(id);
            if (footwear == null)
            {
                return NotFound();
            }

            db.Footwears.Remove(footwear);
            db.SaveChanges();

            return Ok(footwear);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FootwearExists(int id)
        {
            return db.Footwears.Count(e => e.FootwearID == id) > 0;
        }
    }
}