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
        public class citiyController : ApiController
        {
        private CountryDBEntities db = new CountryDBEntities();

        // GET: api/countries
        public IQueryable<city1> Getcountries()
        {
            return db.cityies;
        }

        // GET: api/countries/5
        [ResponseType(typeof(city1))]
        public async Task<IHttpActionResult> Getcountry(int id)
        {
            city1 country = await db.cityies.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        // PUT: api/countries/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcountry(int id, city1 country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != country.id)
            {
                return BadRequest();
            }

            db.Entry(country).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!countryExists(id))
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

        // POST: api/countries
        [ResponseType(typeof(city1))]
        public async Task<IHttpActionResult> Postcountry(city1 country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.cityies.Add(country);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = country.id }, country);
        }

        // DELETE: api/countries/5
        [ResponseType(typeof(city1))]
        public async Task<IHttpActionResult> Deletecountry(int id)
        {
            city1 country = await db.cityies.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            db.cityies.Remove(country);
            await db.SaveChangesAsync();

            return Ok(country);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool countryExists(int id)
        {
            return db.cityies.Count(e => e.id == id) > 0;
        }
    }
    }