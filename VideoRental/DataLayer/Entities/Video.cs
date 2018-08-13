using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{
     public class Video : IVideo
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public double BasicRentalPrice { get; set; }
        public double LateReturnFee { get; set; }
        public int RentalDays { get; set; }

        [System.ComponentModel.DefaultValue(false)]
        public bool IsRented { get; set; }

        public Video() {}

        public Video(IVideo video )
        {
            Id = video.Id;
            GenreId = video.GenreId;
            Name = video.Name;
            RentalDays = video.RentalDays;
            BasicRentalPrice = video.BasicRentalPrice;
            LateReturnFee = video.LateReturnFee;
            IsRented = video.IsRented;
        }
      
    }
}
