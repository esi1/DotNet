using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Areas.Admin.Extensions
{
    public static class ICollectionExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this ICollection<T> items, int selectedValue)
        {
            try
            {
                //if(items != null)
                //{
                var itemList =  from item in items
                       select new SelectListItem
                       {
                           Text = item.GetPropertyValue("Title"),
                           Value = item.GetPropertyValue("Id"),
                           Selected = item.GetPropertyValue("Id")
                            .Equals(selectedValue.ToString())
                       };

                if (itemList == null) return new List<SelectListItem>();

                return itemList;
            //}
        }
            catch
            {
               return new List<SelectListItem>();

            }
            //return null;
        }
    }
}