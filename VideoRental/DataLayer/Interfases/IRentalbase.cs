using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfases
{
    public interface IRentalbase
    {
        #region Action Methods
        void AddVideo(IVideo video);
        void AddGenre(IGenre genre);
        void AddCustomer(ICustomer customer);
        void UpdateVideo(IItem item);
        void UpdateCustomer(IItem item);
        void UpdateGenre(IItem item);
        //IGenre UpdateGenre(IItem item);
        void UpdateVideoBooking();
        void DeleteGenre(IGenre genre);
        void DeleteCustomer(ICustomer customer);
        void DeleteVideo(IVideo video);
        bool RentVideo(int videoId, int customerId, DateTime timeOfRental);
        void ReturnVideo(IItem videoBooking, DateTime returnDate);
        #endregion

        #region Fetch Methods
        Dictionary<int, IVideo> GetVideos(VideoStatus status);
        Dictionary<int, IGenre> GetGenres();
        Dictionary<int, ICustomer> GetCustomers();
        Dictionary<int, IVideoBooking> GetBookings();
        #endregion
    }
}
