using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Exception
{
    public class VideoRentalException : ApplicationException
    {
        public IItem Item { get; }
        public VideoRentalException(IItem item, string message = "Item could not be handled")
            : base(String.Format("{0}, Item: {1}", message, item.Name))
        {
            Item = item;
        }
        
    }
}
