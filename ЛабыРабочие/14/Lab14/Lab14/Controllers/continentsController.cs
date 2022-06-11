﻿using System;
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
    public class continentsController : Controller
    {
        private CountryDBEntities db = new CountryDBEntities();

        // GET: continents
        public async Task<ActionResult> Index()
        {
            return View(await db.continents.ToListAsync());
        }

        // GET: continents/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            continent continent = await db.continents.FindAsync(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        // GET: continents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: continents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,name,photo")] continent continent)
        {
            if (ModelState.IsValid)
            {
                db.continents.Add(continent);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(continent);
        }

        // GET: continents/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            continent continent = await db.continents.FindAsync(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        // POST: continents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,name,photo")] continent continent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(continent).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(continent);
        }

        // GET: continents/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            continent continent = await db.continents.FindAsync(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        // POST: continents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            continent continent = await db.continents.FindAsync(id);
            db.continents.Remove(continent);
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
