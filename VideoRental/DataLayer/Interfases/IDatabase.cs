using DataLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfases
{
     public interface IDatabase : IRentalbase
    {
        //Customer UpdateCustomer(IItem item);
        #region Helper Methods
        int RentalDuration(DateTime rented, DateTime returned);

        double CalculatePrice(IVideo video, int duration);
        #endregion

    }
}
