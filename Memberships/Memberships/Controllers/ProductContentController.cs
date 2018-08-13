﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using Memberships.Extensions;

namespace Memberships.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;
            var sections = await SectionExtensions.GetProductSectionsAsync(id,userId);
            var downloads = await SectionExtensions.GetProductDownloadSectionsAsync(id, userId);
                 sections.Sections.Add(downloads);

            return View(sections);
        }

        public async Task<ActionResult> Content(int productId, int itemId)
        {
            var model = await SectionExtensions.GetContentAsync(productId, itemId);
            return View("Content", model);
        }

    }
}