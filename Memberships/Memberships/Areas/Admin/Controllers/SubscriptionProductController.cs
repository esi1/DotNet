﻿using System;
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
using Memberships.Areas.Admin.Models;

namespace Memberships.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SubscriptionProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/SubscriptionProduct
        public async Task<ActionResult> Index()
        {
            return View(await db.SubscriptionProducts.Convert(db));
        }

        // GET: Admin/SubscriptionProduct/Details/5
        public async Task<ActionResult> Details(int? SubscriptionId, int? productId)
        {
            if (SubscriptionId == null || productId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriptionProduct subscriptionProduct = await GetSubscriptionProduct(SubscriptionId, productId);
            if (subscriptionProduct == null)
            {
                return HttpNotFound();
            }
            var model = await subscriptionProduct.Convert(db);
            return View(model);
        }

        // GET: Admin/SubscriptionProduct/Create
        public async Task<ActionResult> Create()
        {
            var model = new SubscriptionProductModel
            {
                Subscriptions = await db.Subscriptions.ToListAsync(),
                Products = await db.Products.ToListAsync()
            };
            return View(model);
        }

        // POST: Admin/SubscriptionProduct/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductId,SubscriptionId")] SubscriptionProduct subscriptionProduct)
        {
            if (ModelState.IsValid)
            {
                db.SubscriptionProducts.Add(subscriptionProduct);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(subscriptionProduct);
        }

        // GET: Admin/SubscriptionProduct/Edit/5
        public async Task<ActionResult> Edit(int? SubscriptionId, int? productId)
        {
            if (SubscriptionId == null || productId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriptionProduct subscriptionProduct = await GetSubscriptionProduct(SubscriptionId, productId);
            if (subscriptionProduct == null)
            {
                return HttpNotFound();
            }
            var model = await subscriptionProduct.Convert(db);
            return View(model);
        }

        // POST: Admin/SubscriptionProduct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductId,SubscriptionId,OldSubscriptionId,OldProductId")] SubscriptionProduct subscriptionProduct)
        {
            if (ModelState.IsValid)
            {
                var canChange = await subscriptionProduct.CanChange(db);
                if (canChange)
                {
                    // Change the SubscriptionProduct
                    await subscriptionProduct.Change(db);
                }
                return RedirectToAction("Index");
            }
            return View(subscriptionProduct);
        }

        // GET: Admin/SubscriptionProduct/Delete/5
        //public async Task<ActionResult> Delete(int? SubscriptionId)
        //{
        //    if (SubscriptionId == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SubscriptionProduct subscriptionProduct = await db.SubscriptionProducts.FindAsync(SubscriptionId);
        //    if (subscriptionProduct == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(subscriptionProduct);
        //}
        public async Task<ActionResult> Delete(int? SubscriptionId, int? productId)
        {
            if (SubscriptionId == null || productId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriptionProduct subscriptionProduct = await GetSubscriptionProduct(SubscriptionId, productId);
            if (subscriptionProduct == null)
            {
                return HttpNotFound();
            }
            var model = await subscriptionProduct.Convert(db);
            return View(model);
        }

        // POST: Admin/SubscriptionProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int SubscriptionId,int productId)
        {
            SubscriptionProduct subscriptionProduct = await GetSubscriptionProduct(SubscriptionId, productId);
            db.SubscriptionProducts.Remove(subscriptionProduct);
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
        private async Task<SubscriptionProduct> GetSubscriptionProduct(int? subscriptionId, int? productId)
        {
            try
            {
                int subscrId = 0, prdId = 0;
                int.TryParse(subscriptionId.ToString(), out subscrId);
                int.TryParse(productId.ToString(), out prdId);
                var subscriptionProduct = await db.SubscriptionProducts.FirstOrDefaultAsync(pi =>
                pi.ProductId.Equals(prdId) && pi.SubscriptionId.Equals(subscrId));
                return subscriptionProduct;
            }
            catch { return null; }
        }

    }
}
