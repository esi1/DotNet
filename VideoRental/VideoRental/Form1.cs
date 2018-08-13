using BusinessLayer.Classes;
using BusinessLayer.Interfaces;
using DataLayer.Classes;
using DataLayer.Exception;
using DataLayer.Enums;
using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRental.Classes;
using System.Text.RegularExpressions;
using DataLayer.Entities;

namespace VideoRental
{
    public partial class Form1 : Form
    {
        IBooking booking;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            booking = new Booking( new Database());
            FillCustomers();
            FillGenres();
            FillVideos();
            FillAvailbaleVideos();
            FillBookedVideos();
        }
        #region Action Methods
        //private bool RentVideo()        // Work in progress i.e not complete!!!
        //{
        //    bool success = false;

        //    try
        //    {
                //if (lvwfilms.SelectedItems.Count < 1)
                //{
                //    MessageBox.Show(
                //        "Something went wrong, a video must be selected");
                //    return success;
                //}

                //if (lvwFilms.SelectedItems.Count == 0)
                //{
                //    MessageBox.Show("A video must be selected in the list");
                //    return success;
                //}

                //var vehicleId = Int32.Parse(
                //    lvwFilms.SelectedItems[0].SubItems[3].Text);

               // var customerId = ((ComboClass)lvwFilms.SelectedItems).Id;

              //  success = booking.RentVideo(vehicleId, customerId,
             //       DateTime.Now);

        //        FillAvailbaleVideos();
        //    }
        //    catch { success = false; }

        //    return success;
        //}
        private Genre UpdateGenre(IItem item)
        {
            try
            {
                

                booking.UpdateGenre(item);
                FillGenres();
                return (Genre)item;
            }
            catch {
                throw;
            }
        }
        private Customer UpdateCustomer(IItem item)
        {
            try
            {

                booking.UpdateCustomer(item);
                return (Customer)item;
            }
            catch
            {
                throw;
            }
        }
        private void UpdateVideo(IItem item)
        {
            try
            {
                
                booking.UpdateVideo(item);
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region Add Methods
        private int AddCustomer()
        {
            try
            {
                string errMsg = String.Empty;
               if( IsNumeric(txtCustomersFirstName.Text) || IsNumeric( txtCustomersLastName.Text) )
                    errMsg = " first name or last name can not contain numbers" + Environment.NewLine;
                if (txtCustomersFirstName.TextLength == 0)
                    errMsg += "Incorrect first name" + Environment.NewLine;
                if (txtCustomersLastName.TextLength == 0)
                    errMsg += "Incorrect last name" + Environment.NewLine;
                if ( txtCustomersFirstName.TextLength == 0 || txtCustomersLastName.TextLength == 0
                    || IsNumeric(txtCustomersFirstName.Text) || IsNumeric(txtCustomersLastName.Text))
                {
                    MessageBox.Show(errMsg);
                    return -1;
                }
                var customer = new Customer()
                {
                    FirstName = txtCustomersFirstName.Text,
                    LastName = txtCustomersLastName.Text
                };
                booking.AddCustomer(customer);
                FillCustomers();
               
                txtCustomersFirstName.Text = String.Empty;
                txtCustomersLastName.Text = String.Empty;
                return cboCustomersCustomer.Items.Count - 1;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return Int32.MinValue;
            }
            catch
            {
                return -1;
            }
        }

        private int AddVideo()
        {
            try
            {
                string errMsg = String.Empty;
                if (IsNumeric(txtVideosName.Text) )
                    errMsg = " video name can not contain numbers" + Environment.NewLine;
                if (txtVideosName.TextLength == 0)
                    errMsg += "Incorrect video name" + Environment.NewLine;
                if (cboVideosGenre.SelectedIndex < 0)   //Any genre selected
                    errMsg += "No genre is selected." + Environment.NewLine;
              
                if (numVideosDays.Value < 1)    //Enough days selected
                    errMsg += "Too few rental days selected." + Environment.NewLine;
                if (txtVideosName.TextLength == 0 || IsNumeric(txtVideosName.Text) ||
                    cboVideosGenre.SelectedIndex < 0 || numVideosDays.Value < 1 )
                {
                    MessageBox.Show(errMsg);
                    return -1;
                }
                var video = new Video()
                {
                    GenreId = ((ComboClass)cboVideosGenre.SelectedItem).Id,
                    Name = txtVideosName.Text,
                    RentalDays = (int) numVideosDays.Value
                   
                };
                booking.AddVideo(video);
                FillVideos();
                FillAvailbaleVideos();
                txtVideosName.Text = String.Empty;
               
                return cboVideosVideo.Items.Count - 1;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return Int32.MinValue;
            }
            catch
            {
                return -1;
            }
        }

        private int AddGenre()
        {
            try
            {
                string errMsg = String.Empty;
                if (IsNumeric(txtGenresName.Text))
                    errMsg = " Genre name can not contain numbers" + Environment.NewLine;
                if (txtGenresName.TextLength == 0)
                    errMsg += "Incorrect genre name" + Environment.NewLine;
                if (txtGenresName.TextLength == 0 || IsNumeric(txtGenresName.Text) )
                {
                    MessageBox.Show(errMsg);
                    return -1;
                }
                var genre = new Genre()
                {
                    Name = txtGenresName.Text
                };
                booking.AddGenre(genre);
                FillGenres();

                txtGenresName.Text = String.Empty;
                
                return cboGenresGenre.Items.Count - 1;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return Int32.MinValue;
            }
            catch
            {
                return -1;
            }
        }
        #endregion
        #region Delete Methods
        private int DeleteCustomer()
        {
            try
            {
                string errMsg = String.Empty;
               
                if (cboCustomersCustomer.SelectedIndex < 0)
                    errMsg = "No customer selected" + Environment.NewLine;
                if (cboCustomersCustomer.SelectedIndex < 0)
                {
                    MessageBox.Show(errMsg);
                    return -1;
                }
                
                var customer = new Customer()
                {
                    Id= ((ComboClass)cboCustomersCustomer.SelectedItem).Id,
                    Name = ((ComboClass)cboCustomersCustomer.SelectedItem).Name
                };
                booking.DeleteCustomer(customer);
                FillCustomers();
                FillBookedVideos();

                return cboCustomersCustomer.Items.Count - 1;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return Int32.MinValue;
            }
            catch
            {
                return -1;
            }
        }
        
        private int DeleteVideo()
        {
            try
            {
                string errMsg = String.Empty;
                if (cboVideosVideo.SelectedIndex < 0)
                    errMsg = "No video selected" + Environment.NewLine;
                if (cboVideosVideo.SelectedIndex < 0)
                {
                    MessageBox.Show(errMsg);
                    return -1;
                }
                var video = new Video()
                {
                     Id = ((ComboClass)cboVideosVideo.SelectedItem).Id,
                    Name = ((ComboClass)cboVideosVideo.SelectedItem).Name
                    
                };
                booking.DeleteVideo(video);
                FillVideos();
                FillAvailbaleVideos();
                FillBookedVideos();
                return cboVideosVideo.Items.Count - 1;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return Int32.MinValue;
            }
            catch
            {
                return -1;
            }
        }

        private int DeleteGenre()
        {
            try
            {
                string errMsg = String.Empty;

                if (cboGenresGenre.SelectedIndex < 0)
                    errMsg = "No genre selected" + Environment.NewLine;
                if (cboGenresGenre.SelectedIndex < 0)
                {
                    MessageBox.Show(errMsg);
                    return -1;
                }
                var genre = new Genre()
                {
                    Id= ((ComboClass)cboGenresGenre.SelectedItem).Id,
                    Name = ((ComboClass)cboGenresGenre.SelectedItem).Name
                };
                booking.DeleteGenre(genre);
                FillGenres();
                FillVideos();
                FillAvailbaleVideos();
                return cboGenresGenre.Items.Count - 1;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return Int32.MinValue;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        private bool RentVideo()
        {
            bool success = false;
            try
            {
                if (cboCustomer.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "A customer must be selected in the drop down list");
                    return success;
                }
                if (lvwFilms.SelectedItems.Count == 0)
                {
                    MessageBox.Show("A video must be selected in the list");
                    return success;
                }
                var videoId = Int32.Parse(lvwFilms.SelectedItems[0].SubItems[3].Text);
                var customerId = ((ComboClass)cboCustomer.SelectedItem).Id;
                success = booking.RentVideo(videoId, customerId, DateTime.Now);
                FillAvailbaleVideos();
                FillBookedVideos();
                
            }
            catch (Exception ex){
                success = false;
            }
            return success;
        }

        private bool ReturnVideo()
        {
            string message = String.Empty;
            Item bookingAsItem = new Item();

            try
            {
                ListViewItem bookingLVI;
                int bookingID = 0;
                var bookingVideoName = String.Empty;
                IVideoBooking _booking;


                while (true)   
                {
                    
                    if (lvwBookings.SelectedItems.Count < 1)
                    {
                        message += "No booking is selected\n";
                        break;
                    }

                    bookingLVI = lvwBookings.SelectedItems[0];
                    bookingID = int.Parse(bookingLVI.SubItems[6].Text);
                    bookingVideoName = bookingLVI.SubItems[1].Text;
                    bookingAsItem.Id = bookingID;
                    bookingAsItem.Name = bookingVideoName;

                    if (!booking.BookingExist(bookingID))  
                    {
                        message += "The selected booking does not exist in the database";
                        break;
                    }

                    _booking =
                        (from b in booking.GetBookings()
                         where b.Key.Equals(bookingID)     
                         select b).First().Value;

                    if (!booking.VideoExist(bookingVideoName))  
                    {
                        message += "The video connected with the selected booking does not exist in the database. VideoId: " + _booking.VideoId;
                        break;
                    }

                    var _video = booking.GetVideos(VideoStatus.All).FirstOrDefault(c => c.Key.Equals(_booking.VideoId)).Value;

                    if (_video.IsRented == false)
                    {
                        message += "The video is not rented";
                        break;
                    }

                    if (dateTimePicker.Value < _booking.Rented)
                    {
                        message += "Incorrect date input. Return date must be equal or later than rental date\n";
                        break;
                    }

                    booking.ReturnVideo(bookingAsItem, dateTimePicker.Value);
                    break;
                }

                if (message.Length > 0)  
                {
                    throw new VideoRentalException(bookingAsItem, message);
                }

                return true;
            }
            catch (VideoRentalException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

     

        #region Fill Methods
        private void FillCustomers()
        {
            try
            {
                var customer = from c in booking.GetCustomers()
                               select new ComboClass
                               {
                                   Id = c.Value.Id,
                                   Name = String.Format("{0} {1} ", c.Value.LastName, c.Value.FirstName) 
                               };
                cboCustomersCustomer.Items.Clear();
                cboCustomersCustomer.Items.AddRange(customer.ToArray());
                cboCustomersCustomer.DisplayMember = "Name";

                cboCustomer.Items.Clear();
                cboCustomer.Items.AddRange(customer.ToArray());
                cboCustomer.DisplayMember = "Name";
            }
            catch
            { }
        }

        private void FillGenres()
        {
            try
            {
                var genre = from c in booking.GetGenres()
                               select new ComboClass
                               {
                                   Id = c.Value.Id,
                                   Name = String.Format("{0}  ", c.Value.Name),

                               };
                cboGenresGenre.Items.Clear();
                cboGenresGenre.Items.AddRange(genre.ToArray());
                cboGenresGenre.DisplayMember = "Name";

                cboVideosGenre.Items.Clear();
                cboVideosGenre.Items.AddRange(genre.ToArray());
                cboVideosGenre.DisplayMember = "Name";
            }
            catch
            { }
        }

        private void FillVideos()
        {
            try
            {
                var video = from c in booking.GetVideos(VideoStatus.All)
                               select new ComboClass
                               {
                                   Id = c.Value.Id,
                                   Name = String.Format("{0}  ", c.Value.Name),

                               };
                cboVideosVideo.Items.Clear();
                cboVideosVideo.Items.AddRange(video.ToArray());
                cboVideosVideo.DisplayMember = "Name";
            }
            catch
            { }
        }

        private IEnumerable<ListViewItem> GetAvailableVideos(VideoStatus videoStatus)
        {
            var s = from v in booking.GetVideos(videoStatus)
                       join g in booking.GetGenres() on v.Value.GenreId equals g.Value.Id
                        select
                              new ListViewItem(new string[]
                             {
                                 
                                 v.Value.Name,                  
                                 g.Value.Name,                 
                                 v.Value.RentalDays.ToString(), 
                                v.Value.Id.ToString()           
                             });
            return s;
        }
        private IEnumerable<ListViewItem> GetBookedVideos(VideoStatus videoStatus)
        {
            var s = from v in booking.GetVideos(videoStatus)
                    join b in booking.GetBookings() on v.Value.Id equals b.Value.VideoId
                    join g in booking.GetGenres() on v.Value.GenreId equals g.Value.Id
                    join c in booking.GetCustomers() on b.Value.CustomerId equals c.Value.Id
                    select
                           new ListViewItem(new ListViewBooking
                           {
                               BookingId = b.Value.Id,
                               CustomerId = c.Value.Id,
                               Customer = String.Format("{0} {1}", c.Value.LastName , c.Value.FirstName),
                               Title = v.Value.Name,
                               Genre = g.Value.Name,
                               Rented = b.Value.Rented,
                               Returned = b.Value.Returned,
                               Cost = b.Value.Cost
                             }.ToArray());
            return s;
        }
       
        private void FillAvailbaleVideos()
        {
            var videos = GetAvailableVideos(VideoStatus.Available);
            lvwFilms.Items.Clear();
            lvwFilms.Items.AddRange(videos.ToArray());
        }

        private void FillBookedVideos()
        {
            var videos = GetBookedVideos(VideoStatus.All);
            lvwBookings.Items.Clear();
            lvwBookings.Items.AddRange(videos.ToArray());
        }
        
        #endregion
        #region Button Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Uppdate Events
        private void btnGenresUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var newGenre = new Customer();
                newGenre.Id = ((ComboClass)cboGenresGenre.SelectedItem).Id;
                //if(cboGenresGenre.SelectedItem == null)
                if (txtGenresName.Text.Length < 1)
                {
                    throw new Exception("Name is too short.");
                }
                newGenre.Name = txtGenresName.Text;
                UpdateGenre(newGenre);
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("{0}\n{1}", ex.Message, "Genre is not updated"));
            }
        }

        private void btnCustomersUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var newCustomer = new Customer();
                if (cboCustomersCustomer.SelectedIndex < 0)
                    throw new VideoRentalException(newCustomer, "No Customer is selected.");

                var selectedCustomerId = ((ComboClass)cboCustomersCustomer.SelectedItem).Id;
                var selectedCustomerName = ((ComboClass)cboCustomersCustomer.SelectedItem).Name;
                newCustomer = new Customer() { Id = selectedCustomerId, Name = selectedCustomerName };

                if (txtCustomersFirstName.Text.Length < 1)
                    throw new VideoRentalException(newCustomer, "First name is too short.");

                if (txtCustomersLastName.Text.Length < 1)
                    throw new VideoRentalException(newCustomer, "Last name is too short.");

                newCustomer.FirstName = txtCustomersFirstName.Text;
                newCustomer.LastName = txtCustomersLastName.Text;

                Customer result = UpdateCustomer(newCustomer);
                FillCustomers();
                FillBookedVideos();
                //throw new VideoBookingException("Genre is not updated");
                //throw new VideoRentalException(result, "Customer is not updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVideosUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var errorMsg = String.Empty;

                var newVideo = new Video();

                if (cboVideosVideo.SelectedIndex < 0)   //Any video selectd
                    errorMsg += "No Video is selected." + Environment.NewLine;
                if (cboVideosGenre.SelectedIndex < 0)   //Any genre selected
                    errorMsg += "No genre is selected." + Environment.NewLine;
                if (txtVideosName.Text.Length < 1)  //Any name input
                    errorMsg += "Name is too short." + Environment.NewLine;
                if (numVideosDays.Value < 1)    //Enough days selected
                    errorMsg += "Too few rental days selected." + Environment.NewLine;

                if (errorMsg != String.Empty)    //If any errors have been found
                    throw new VideoRentalException(newVideo, errorMsg);

                newVideo.Id = ((ComboClass)cboVideosVideo.SelectedItem).Id;
                newVideo.GenreId = ((ComboClass)cboVideosGenre.SelectedItem).Id;
                newVideo.Name = txtVideosName.Text;
                newVideo.RentalDays = (int)numVideosDays.Value;

                UpdateVideo(newVideo);

                FillVideos();
                FillBookedVideos();
                FillAvailbaleVideos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Add Events
        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            var idx = AddCustomer();

            if (idx.Equals(Int32.MinValue)) return;
            if (idx.Equals(-1))
            {
                MessageBox.Show("The customer was not added");
                return;
            }
            cboCustomersCustomer.SelectedIndex = idx;
        }

        private void btnGenresAdd_Click(object sender, EventArgs e)
        {
            var idx = AddGenre();

            if (idx.Equals(Int32.MinValue)) return;
            if (idx.Equals(-1))
            {
                MessageBox.Show("The genre was not added");
                return;
            }
            cboGenresGenre.SelectedIndex = idx;
        }

        private void btnVideosAdd_Click(object sender, EventArgs e)
        {
            var idx = AddVideo();

            if (idx.Equals(Int32.MinValue)) return;
            if (idx.Equals(-1))
            {
                MessageBox.Show("The video was not added");
                return;
            }
            cboVideosVideo.SelectedIndex = idx;
        }
        #endregion
        #region Delete Events
        private void btnCustomersDelete_Click(object sender, EventArgs e)
        {
            var idx = DeleteCustomer();

            if (idx.Equals(Int32.MinValue)) return;
            if (idx.Equals(-1))
            {
                MessageBox.Show("The customer was not deleted");
                return;
            }
            cboCustomersCustomer.SelectedIndex = idx;
        }

        private void btnGenresDelete_Click(object sender, EventArgs e)
        {
            var idx = DeleteGenre();

            if (idx.Equals(Int32.MinValue)) return;
            if (idx.Equals(-1))
            {
                MessageBox.Show("The genre was not deleted");
                return;
            }
            cboGenresGenre.SelectedIndex = idx;
        }

        private void btnVideosDelete_Click(object sender, EventArgs e)
        {
            var idx = DeleteVideo();

            if (idx.Equals(Int32.MinValue)) return;
            if (idx.Equals(-1))
            {
                MessageBox.Show("The video was not deleted");
                return;
            }
            cboVideosVideo.SelectedIndex = idx;
        }
        #endregion
        #region Rent and Return Methods
        private void btnReturn_Click(object sender, EventArgs e)
        {
                var success = ReturnVideo();

                FillAvailbaleVideos();
                FillBookedVideos();

                if(!success)
                    MessageBox.Show("Video was not returned");

        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            var rented = RentVideo();
            if (!rented) MessageBox.Show("The video was not rented");
        }
        #endregion
        #endregion

        #region Helper Methods
        bool IsNumeric(string text)
        {
            string b = text.Replace(" ", "");
            return b.Any(char.IsDigit);
        }

        #endregion


    }
}
