using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab14.Models;

namespace Lab14.Controllers
{
    public class countriesController : Controller
    {
        private CountryDBEntities db = new CountryDBEntities();

        // GET: countries
        public async Task<ActionResult> Index()
        {
            var countries = db.countries.Include(c => c.continent);
            return View(await countries.ToListAsync());
        }

        // GET: countries/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            country country = await db.countries.FindAsync(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // GET: countries/Create
        public ActionResult Create()
        {
            ViewBag.id_continent = new SelectList(db.continents, "id", "name");
            return View();
        }

        // POST: countries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,name,id_continent,photo")] country country)
        {
            if (ModelState.IsValid)
            {
                db.countries.Add(country);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.id_continent = new SelectList(db.continents, "id", "name", country.id_continent);
            return View(country);
        }

        // GET: countries/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            country country = await db.countries.FindAsync(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_continent = new SelectList(db.continents, "id", "name", country.id_continent);
            return View(country);
        }

        // POST: countries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,name,id_continent,photo")] country country)
        {
            if (ModelState.IsValid)
            {
                db.Entry(country).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.id_continent = new SelectList(db.continents, "id", "name", country.id_continent);
            return View(country);
        }

        // GET: countries/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            country country = await db.countries.FindAsync(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            country country = await db.countries.FindAsync(id);
            db.countries.Remove(country);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
