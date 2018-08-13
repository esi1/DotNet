using BusinessLayer.Interfaces;
using DataLayer.Classes;
using DataLayer.Enums;
using DataLayer.Exception;
using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class Booking : IBooking
    {
        public IDatabase Database { get; private set; }

        public Booking(IDatabase database)
        {
            Database = database;
        }
        #region Add Methods
        public void AddCustomer(ICustomer customer)
        {
            try
            {
                if (CustomerExist(customer.Name))
                {
                    throw new VideoRentalException(customer,"Customer allredy exict");
                }
                else
                {
                     Database.AddCustomer(customer);
                }
            }
            catch { throw; }
        }

        public void AddVideo(IVideo video)
        {
            try
            {
                if (VideoExist(video.Name))
                {
                    throw new VideoRentalException(video, "Video allredy exict");
                }
                else
                {
                    Database.AddVideo(video);
                }
            }
            catch { throw; }
        }

        public void AddGenre(IGenre genre)
        {
            try
            {
                if (GenreExist(genre.Name))
                {
                    throw new VideoRentalException(genre, "Genre allredy exict");
                }
                else
                {
                    Database.AddGenre(genre);
                }
            }
            catch { throw; }
        }
        #endregion
        #region Delete Methods
        
        public void DeleteGenre(IGenre genre)
        {
            try
            {
                    if (!DoesGenreContainsRentedVideo(genre.Id) || GenreExist(genre.Name))
                    {
                    if(GetVideoByGenreId(genre.Id) == null)
                    {
                        Database.DeleteGenre(genre);
                    }
                    else
                    {
                        DeleteVideo(GetVideoByGenreId(genre.Id));
                        Database.DeleteGenre(genre);
                    } 
                }
                else
                {
                throw new VideoRentalException(genre, "Genre contains rented video");
                }
        }
            catch { throw; }
        }

        public void DeleteCustomer(ICustomer customer)
        {
            try
            {
                if ( !IsCustomerRentVideo(customer.Id) || CustomerExist(customer.Name))
                {
                    Database.DeleteCustomer(customer);
                }
                else
                {
                    throw new VideoRentalException(customer, "Customer has rented video and can not be deleted");
                }
            }
            catch { throw; }
        }

        public void DeleteVideo(IVideo video)
        {
            try
            {
                if (!IsVideoRented(video.Id))
                {
                    Database.DeleteVideo(video);
                }
                else
                {
                    throw new VideoRentalException(video, "Video is rented and can not be deleted");
                }
            }
            catch { throw; }
        }
        #endregion
        #region Get Methods
     
        public Dictionary<int, ICustomer> GetCustomers()
        {
            try
            {
                return Database.GetCustomers();
            }
            catch
            { throw; }
        }

        public Dictionary<int, IGenre> GetGenres()
        {
            try
            {
                return Database.GetGenres();
            }
            catch
            { throw; }
        }

        public Dictionary<int, IVideoBooking> GetBookings()
        {
            try
            {
                return Database.GetBookings();
            }
            catch
            { throw; }
        }

        public Dictionary<int, IVideo> GetVideos(VideoStatus status)
        {
            try
            {
                var x = Database.GetVideos(status);
                return x;
            }
            catch(Exception ex)
            { throw; }
        }
        #endregion
        #region Update Methods
        public void UpdateCustomer(IItem item)
        {
            try
            {
                Database.UpdateCustomer(item);
            }
            catch (Exception)
            { throw; }
        }

        public void UpdateVideo(IItem item)
        {
            try
            {
                Database.UpdateVideo(item);
            }
            catch (Exception)
            { throw; }
        }

        public void UpdateGenre(IItem item)
        {
            try
            {
                Database.UpdateGenre(item);
            }
            catch (Exception)
            { throw; }
        }

        public void UpdateVideoBooking()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Rent/Return Methods

        public bool RentVideo(int videoId, int customerId, DateTime timeOfRental)
        {
            try
            {
                return Database.RentVideo(videoId, customerId, DateTime.Now);
            }
            catch
            {
                throw;
            }
        }
        public void ReturnVideo(IItem videoBooking, DateTime returnDate)
        {
            try
            {
                Database.ReturnVideo(videoBooking, returnDate);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Helper Methods
        public bool CustomerExist(string name)
        {
            var social = (from c in Database.GetCustomers()
                          where c.Value.Name.Equals(name)
                          select c).Count();
            return social > 0;
        }

        public bool VideoExist(string name)
        {
            var social = (from c in Database.GetVideos(VideoStatus.All)
                          where c.Value.Name.Equals(name)
                          select c).Count();
            return social > 0;
        }

            public bool GenreExist(string name)
        {
            var social = (from c in Database.GetGenres()
                          where c.Value.Name.Equals(name)
                          select c).Count();
            return social > 0;
        }

        
        public bool BookingExist(int id)
        {
            var result = (from c in GetBookings()
                          where c.Key.Equals(id)
                          select c).Count();
            return result > 0;
        }

        public bool IsCustomerRentVideo(int customerId)
        {
            var customerBookings = from b in GetBookings() where b.Value.CustomerId.Equals(customerId)
                                               join d in GetVideos(VideoStatus.All)
                                               on b.Value.VideoId equals d.Value.Id
                                               into aBooking
                                               from bookingVideos in aBooking.DefaultIfEmpty()
                                               select new {
                                                                    Id = b.Value.Id,
                                                                    IsRented = bookingVideos.Value.IsRented
                                                                };

            var customersRentedVehicles = from c in customerBookings
                                                          where c.IsRented.Equals(true)
                                                          select c;

            return customersRentedVehicles.Count() > 0;
        }

        public bool DoesGenreContainsRentedVideo(int genreId)
        {
            
            var query1 = from v in GetVideos(VideoStatus.All)
                        where v.Value.GenreId.Equals(genreId)
                        join g in GetGenres()
                        on v.Value.GenreId equals g.Value.Id
                        into videogenre
                        from subpet in videogenre.DefaultIfEmpty()
                        select new
                        {
                            GenreId = subpet.Value.Id,
                            GenreName = subpet.Value.Name,
                            VideoName = (v.Value.Name.Equals(null) ? string.Empty : v.Value.Name),
                            IsRented = (v.Value.IsRented.Equals(null) ? false : v.Value.IsRented)
                        };
            var query2 = from q in query1 where q.IsRented.Equals(true) select q;
     
            return query2.Count() > 0;
        }
        public bool DoesGenreContainsVideo(int genreId)
        {
           
            var query1 = from v in GetVideos(VideoStatus.All)
                         
                         join g in GetGenres()
                         on v.Value.GenreId equals g.Value.Id
                         
                         select new
                         {
                             Video=v, Genre=g
                         };
            var query2 = from q in query1 where q.Genre.Value.Id.Equals(genreId) && q.Video.Value.IsRented.Equals(null)  select q;

            return query2.Count() > 0;
        }
        public  IVideo GetVideoByGenreId(int genreId)
        {

         var video=   (from v in GetVideos(VideoStatus.All) where v.Value.GenreId.Equals(genreId) select v).ToDictionary(x => x.Key, x => x.Value);
            if (video.Values.Count() < 1)
                return null;
            return video.Values.First();
        }
        public bool IsVideoRented(int videoId)
        {
            return (from v in GetVideos(VideoStatus.All) where v.Value.Id.Equals(videoId) select v).
                FirstOrDefault().Value.IsRented.Equals(true);
        }

        #endregion
    }
}
