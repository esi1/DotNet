using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfases
{
     public interface IVideoBooking
    {
         int Id { get; set; }
         int VideoId { get; set; }
         int CustomerId { get; set; }
        DateTime Rented { get; set; }
        DateTime Returned { get; set; }
        double Cost { get; set; }
    }
}
