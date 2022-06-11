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
using Lab15.Models;

namespace Lab15.Controllers
{
    public class countriesController : ApiController
    {
        private CountryDBEntities db = new CountryDBEntities();

        // GET: api/continents
        public IQueryable<Country> Getcontinents()
        {
            return db.countries;
        }

        // GET: api/continents/5
        [ResponseType(typeof(Country))]
        public async Task<IHttpActionResult> Getcontinent(int id)
        {
            Country continent = await db.countries.FindAsync(id);
            if (continent == null)
            {
                return NotFound();
            }

            return Ok(continent);
        }

        // PUT: api/continents/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcontinent(int id, Country continent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != continent.id)
            {
                return BadRequest();
            }

            db.Entry(continent).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!continentExists(id))
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

        // POST: api/continents
        [ResponseType(typeof(Country))]
        public async Task<IHttpActionResult> Postcontinent(Country continent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.countries.Add(continent);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = continent.id }, continent);
        }

        // DELETE: api/continents/5
        [ResponseType(typeof(Country))]
        public async Task<IHttpActionResult> Deletecontinent(int id)
        {
            Country continent = await db.countries.FindAsync(id);
            if (continent == null)
            {
                return NotFound();
            }

            db.countries.Remove(continent);
            await db.SaveChangesAsync();

            return Ok(continent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool continentExists(int id)
        {
            return db.countries.Count(e => e.id == id) > 0;
        }
    }
}