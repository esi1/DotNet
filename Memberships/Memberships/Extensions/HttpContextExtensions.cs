using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin; // Needed for Owin Context
using System.Security.Claims; // Needed for the Claims class

namespace Memberships.Extensions
{
    public static class HttpContextExtensions
    {
        private const string nameidentifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";
        public static string GetUserId(this HttpContextBase ctx)
        {
            string uid = String.Empty;
            try
            {
                var claims = ctx.GetOwinContext()
                .Get<ApplicationSignInManager>()
                .AuthenticationManager.User.Claims
                .FirstOrDefault(claim => claim.Type.Equals(nameidentifier));
                // User is logged in
                if (claims != default(Claim))
                    uid = claims.Value;
            }
            catch { }
            return uid;
        }
    }
}