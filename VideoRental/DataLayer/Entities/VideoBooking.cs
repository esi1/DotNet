using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{
    public class VideoBooking : IVideoBooking
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Rented { get; set; }
        public DateTime Returned { get; set; }
        public double Cost { get; set; }

        public VideoBooking() { }

        public VideoBooking(IVideoBooking videoBooking)
        {
            Id = videoBooking.Id;
            VideoId = videoBooking.VideoId;
            CustomerId = videoBooking.CustomerId;
            Rented = videoBooking.Rented;
            Returned = videoBooking.Returned;
            Cost = videoBooking.Cost;
        }

    }
}
