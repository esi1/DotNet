using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfases
{
    public interface IVideo : IItem
    {
         int GenreId { get; set; }
         double BasicRentalPrice { get; set; }
         double LateReturnFee { get; set; }
         bool IsRented { get; set; }
         int RentalDays { get; set; }
    }
}
