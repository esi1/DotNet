using DataLayer.Data_Sources;
using DataLayer.Enums;
using DataLayer.Exception;
using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{

    public class Database : IDatabase
    {
        public Database()
        {
            new TestData().Seed();
        }
        #region Add Methods
        public void AddCustomer(ICustomer customer)
        {
            try
            {
                customer.Id = TestData.customers.Max(b => b.Value.Id) + 1;
               
                TestData.customers.Add(customer.Id,customer);
        }
            catch { throw; }
        }

        public void AddVideo(IVideo video)
        {
            try
            {
                video.Id = TestData.vidoes.Max(b => b.Value.Id) + 1;

                TestData.vidoes.Add(video.Id, video);
        }
            catch { throw; }
        }

        public void AddGenre(IGenre genre)
        {
            try
            {
                genre.Id = TestData.genres.Max(b => b.Value.Id) + 1;

                TestData.genres.Add(genre.Id, genre);
            }
            catch { throw; }
        }
        #endregion
        #region Delete Methods
        public void DeleteCustomer(ICustomer customer)
        {
            try
            {
                TestData.customers.Remove(customer.Id);
            }
            catch { throw; }
        }

        public void DeleteGenre(IGenre genre)
        {
            try
            {
                TestData.genres.Remove(genre.Id);
            }
            catch { throw; }
        }

        public void DeleteVideo(IVideo video)
        {
            try
            {
                TestData.vidoes.Remove(video.Id);
            }
            catch { throw; }
        }
        //
        public Dictionary<int, IVideoBooking> GetBookings()
        {
            return TestData.videoBookings;
        }

       
        #endregion
        #region Get Methods
       
        public Dictionary<int, ICustomer> GetCustomers()
        {
            return TestData.customers;
        }

        public Dictionary<int, IGenre> GetGenres()
        {
            return TestData.genres;
        }

        public Dictionary<int, IVideo> GetVideos(VideoStatus status)
        {
            switch (status)
            {
                case VideoStatus.All:
                        return TestData.vidoes;    
                case VideoStatus.Booked:
                    return (from c in TestData.vidoes
                            join b in TestData.videoBookings on c.Value.Id equals b.Value.VideoId
                            where c.Value.IsRented.Equals(true)
                            select c).Distinct().ToDictionary(x => x.Key, x => x.Value);               
                case VideoStatus.Available:                    
                    return (from c in TestData.vidoes
                            where GetVideos(VideoStatus.Booked)
                            .Count(b => b.Value.Id.Equals(c.Value.Id)).Equals(0)
                            select c).ToDictionary(x => x.Key, x => x.Value);
            }
            return TestData.vidoes;
        }

        public int RentalDuration(DateTime rented, DateTime returned)
        {
            TimeSpan time = returned - rented;
            if (time.Days == 0 && returned.TimeOfDay - rented.TimeOfDay > TimeSpan.MinValue)
                return 1;
            else
                return time.Days;
        }

        public double CalculatePrice(IVideo video, int duration)
        {
            if (video.RentalDays < duration)
            {
                return video.BasicRentalPrice * duration + video.LateReturnFee * (duration-video.RentalDays);
            }
            else
            {              
                return video.BasicRentalPrice * duration;

            }
        }

        #endregion
        #region Update Methods
        public void UpdateCustomer(IItem item)
        {
            try
            {
                Customer cust = (Customer)item;

                var customers = GetCustomers();
                if(!customers.ContainsKey(item.Id))
                    throw new VideoRentalException(new Customer(), "Cannot update customer, invalid ID");
                
                var equalCustomers = (from c in customers
                                     where c.Value.FirstName.Equals(cust.FirstName)
                                     
                    join d in customers
                    on  cust.LastName equals d.Value.LastName
                                      select new Customer() { Id = c.Key, FirstName = c.Value.FirstName, LastName = d.Value.LastName });

                if(equalCustomers.Count() > 0)
                    throw new VideoRentalException(item, "Cannot update customer, identical data found");

               TestData.customers[item.Id].FirstName = cust.FirstName;
               TestData.customers[item.Id].LastName = cust.LastName;

            }
            catch (System.Exception)
        {

                throw;
            }
        }

        public void UpdateGenre(IItem item)
        {
            try
            {
                Genre genre = (Genre)item;
                var nameList = 
                    (from g in TestData.genres
                    select g.Value.Name).ToList();

                if(nameList.Contains(genre.Name))
                    throw new System.Exception("That genre already exists.");

                
                (from g in TestData.genres
                    where g.Value.Id.Equals(genre.Id)
                    select g)
                    .First().Value.Name = genre.Name;
            }
            catch
            {
                throw;
            }
        }

        public void UpdateVideo(IItem item)
        {
            try
            {
                Video video = (Video)item;

                var videos = GetVideos(VideoStatus.All);
                if(!videos.ContainsKey(item.Id))
                    throw new VideoRentalException(video, "Cannot update customer, invalid ID");

                var equalVideos = (from c in videos
                                      where c.Value.Name.Equals(video.Name)
                                      select new Video() { Id = c.Value.Id, Name = c.Value.Name, GenreId = c.Value.GenreId });

                if (equalVideos.Count() > 0)
                    throw new VideoRentalException(item, "Cannot update video, identical data found");

                
                TestData.vidoes[item.Id].Name = video.Name;
                TestData.vidoes[item.Id].GenreId = video.GenreId;
                TestData.vidoes[item.Id].RentalDays = video.RentalDays;
            }
            catch (System.Exception)
        {

                throw;
            }
        }

        public void UpdateVideoBooking()
        {
            throw new NotImplementedException();
        }

        #endregion
        #region Rent/Return methods
        public bool RentVideo(int videoId, int customerId, DateTime timeOfRental)
        {
            try
            {
                var bookingId = TestData.videoBookings.Max(b => b.Value.Id) + 1;
                var video =
                    (from b in GetVideos(VideoStatus.All)
                     where b.Key.Equals(videoId)
                     select b.Value).FirstOrDefault();
                video.IsRented = true;
                TestData.videoBookings.Add(bookingId,new VideoBooking()
                {
                    Id = bookingId,
                    VideoId = videoId,
                    CustomerId = customerId,
                    Rented = timeOfRental
            });
                return true;
            }
            catch
            {
                throw;
            }
        }
        public void ReturnVideo(IItem videoBookingAsItem, DateTime returnDate)
        {
            try
            {
                
                var thisVideoBooking =
                    (from b in TestData.videoBookings
                    where b.Key.Equals(videoBookingAsItem.Id)
                    select b.Value).FirstOrDefault();

                if (thisVideoBooking == null)
                    throw new VideoRentalException(videoBookingAsItem, "The booking displayed in the list does not exist\n");

                var thisVideo =
                    (from b in TestData.vidoes
                     where b.Key.Equals(thisVideoBooking.VideoId)
                     select b.Value).FirstOrDefault();

              
                thisVideoBooking.Returned = returnDate;
                thisVideo.IsRented = false;

                var _rentalDuration = RentalDuration(
                    thisVideoBooking.Rented, thisVideoBooking.Returned);
                var _price = CalculatePrice(thisVideo, _rentalDuration);
                thisVideoBooking.Cost = _price;
            }
            catch
            {
                throw;
            }
        }
        #endregion

    }

}
