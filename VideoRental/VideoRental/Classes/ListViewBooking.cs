using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Classes
{
    class ListViewBooking
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime Rented { get; set; }
        public DateTime Returned { get; set; }
        public double Cost { get; set; }

        public string[] ToArray()
        {
            return new string[]
            {
               
                Customer,   
                Title,     
                Genre,
                Rented.ToString(),
                Returned == DateTime.MinValue ? String.Empty : Returned.ToString(),
                Cost.ToString(),
                BookingId.ToString(),   
                CustomerId.ToString()  
            };
        }
    }
}
