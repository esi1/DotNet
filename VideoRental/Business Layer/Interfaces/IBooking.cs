using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IBooking : IDatalayer
    {
        IDatabase Database { get; }
        bool CustomerExist(string name);
        bool GenreExist(string name);
        bool VideoExist(string name);
        bool BookingExist(int id);
        bool IsCustomerRentVideo(int customerId);
        bool DoesGenreContainsRentedVideo(int genreId);
        bool IsVideoRented(int videoId);
        IVideo GetVideoByGenreId(int genreId);
    }
}
