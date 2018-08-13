using DataLayer.Classes;
using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data_Sources
{
   public class TestData
    {
        #region Collections
        internal static Dictionary<int, IVideo> vidoes = new Dictionary<int, IVideo>();
        internal static Dictionary<int, IGenre> genres = new Dictionary<int, IGenre>();
        internal static Dictionary<int, ICustomer> customers = new Dictionary<int, ICustomer>();
        internal static Dictionary<int, IVideoBooking> videoBookings = new Dictionary<int, IVideoBooking>();
        #endregion
        internal void Seed()
        {
            #region VideoData
            const double basicRentalPrice = 50;
            const double lateReturnFee = 20;
           
            Video videoOne = new Video() { Id = 1, GenreId = 2, Name = "Tillbaka till framtiden",RentalDays = 1, BasicRentalPrice = basicRentalPrice, LateReturnFee = lateReturnFee, IsRented = false };
            Video videoTwo = new Video() { Id = 2, GenreId = 4, Name = "Sagan om ringen", RentalDays = 2, BasicRentalPrice = basicRentalPrice, LateReturnFee = lateReturnFee, IsRented = true };
            Video videoThree = new Video() { Id = 3, GenreId = 1, Name = "Hero", RentalDays = 1, BasicRentalPrice = basicRentalPrice, LateReturnFee = lateReturnFee, IsRented = false };

            vidoes.Add(videoOne.Id, videoOne);
            vidoes.Add(videoTwo.Id, videoTwo);
            vidoes.Add(videoThree.Id, videoThree);           
            #endregion

            #region GenreData
            Genre genreOne = new Genre() { Id = 1, Name = "Action" };
            Genre genreTwo = new Genre() { Id = 2, Name = "SciFi" };
            Genre genreThree = new Genre() { Id = 3, Name = "Horror" };
            Genre genreFour = new Genre() { Id = 4, Name = "Fantasy" };
            genres.Add(genreOne.Id, genreOne);
            genres.Add(genreTwo.Id, genreTwo);
            genres.Add(genreThree.Id, genreThree);
            genres.Add(genreFour.Id, genreFour);
            #endregion

            #region CustomerData
            Customer customerOne = new Customer() { Id = 1, FirstName = "Karl", LastName = "West" };
            Customer customerTwo = new Customer() { Id = 2, FirstName = "Jone", LastName = "Karlsson" };
            Customer customerThree = new Customer() { Id = 3, FirstName = "Daniel", LastName = "Doe" };
            customers.Add(customerOne.Id, customerOne);
            customers.Add(customerTwo.Id, customerTwo);
            customers.Add(customerThree.Id, customerThree);
            #endregion

            #region BookingData
            VideoBooking videoBookingOne = new VideoBooking() { Id = 1, CustomerId = 1, VideoId = 1, Rented = DateTime.Now, Returned = DateTime.Now.AddDays(2), Cost = 120 };
            VideoBooking videoBookingTwo = new VideoBooking() { Id = 2, CustomerId = 3, VideoId = 2, Rented = DateTime.Now };
            videoBookings.Add(videoBookingOne.Id, videoBookingOne);
            videoBookings.Add(videoBookingTwo.Id, videoBookingTwo);
            #endregion
        }
    }
}
