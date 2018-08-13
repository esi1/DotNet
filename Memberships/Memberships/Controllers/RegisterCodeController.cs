using Memberships.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Controllers
{
    public class RegisterCodeController : Controller
    {
        public async Task<ActionResult> Register(string code)
        {
            if (Request.IsAuthenticated)
            {
                // Extension method for fetching the user id
                var userId = HttpContext.GetUserId();
                // Extension method for registering a code with a user
                var registered = await SubscriptionExtensions.RegisterUserSubscriptionCode(code, userId);
                if (!registered) throw new ApplicationException();
                return PartialView("_RegisterCodePartial");
            }
            return View();
        }



    }
}