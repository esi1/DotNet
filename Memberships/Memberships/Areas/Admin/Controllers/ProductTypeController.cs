using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Memberships.Entities;
using Memberships.Models;

namespace Memberships.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductTypeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/ProductType
        public async Task<ActionResult> Index()
        {
            return View(await db.ProductTypes.ToListAsync());
        }

        // GET: Admin/ProductType/Details/5
        public async Task<ActionResult> Details(int? ItemId)
        {
            if (ItemId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType productType = await db.ProductTypes.FindAsync(ItemId);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // GET: Admin/ProductType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductType productType)
        {
            if (ModelState.IsValid)
            {
                db.ProductTypes.Add(productType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(productType);
        }

        // GET: Admin/ProductType/Edit/5
        public async Task<ActionResult> Edit(int? ItemId)
        {
            if (ItemId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType productType = await db.ProductTypes.FindAsync(ItemId);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // POST: Admin/ProductType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProductType productType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(productType);
        }

        // GET: Admin/ProductType/Delete/5
        public async Task<ActionResult> Delete(int? ItemId)
        {
            if (ItemId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType productType = await db.ProductTypes.FindAsync(ItemId);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // POST: Admin/ProductType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int ItemId)
        {
            ProductType productType = await db.ProductTypes.FindAsync(ItemId);
            db.ProductTypes.Remove(productType);
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
