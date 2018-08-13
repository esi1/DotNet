namespace VideoRental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbctlVideoRental = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRent = new System.Windows.Forms.Button();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblFilms = new System.Windows.Forms.Label();
            this.lvwFilms = new System.Windows.Forms.ListView();
            this.colTitleFilms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenreFilms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentalDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBookings = new System.Windows.Forms.Label();
            this.lvwBookings = new System.Windows.Forms.ListView();
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpgMaintenance = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numVideosDays = new System.Windows.Forms.NumericUpDown();
            this.txtVideosName = new System.Windows.Forms.TextBox();
            this.btnVideosAdd = new System.Windows.Forms.Button();
            this.btnVideosUpdate = new System.Windows.Forms.Button();
            this.btnVideosDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboVideosGenre = new System.Windows.Forms.ComboBox();
            this.cboVideosVideo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomersLastName = new System.Windows.Forms.TextBox();
            this.txtCustomersFirstName = new System.Windows.Forms.TextBox();
            this.btnCustomersAdd = new System.Windows.Forms.Button();
            this.btnCustomersUpdate = new System.Windows.Forms.Button();
            this.btnCustomersDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustomersCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGenresName = new System.Windows.Forms.TextBox();
            this.btnGenresAdd = new System.Windows.Forms.Button();
            this.btnGenresUpdate = new System.Windows.Forms.Button();
            this.btnGenresDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGenresGenre = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbctlVideoRental.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbpgMaintenance.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVideosDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctlVideoRental
            // 
            this.tbctlVideoRental.Controls.Add(this.tabPage1);
            this.tbctlVideoRental.Controls.Add(this.tabPage2);
            this.tbctlVideoRental.Controls.Add(this.tbpgMaintenance);
            this.tbctlVideoRental.Location = new System.Drawing.Point(13, 13);
            this.tbctlVideoRental.Name = "tbctlVideoRental";
            this.tbctlVideoRental.SelectedIndex = 0;
            this.tbctlVideoRental.Size = new System.Drawing.Size(710, 405);
            this.tbctlVideoRental.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRent);
            this.tabPage1.Controls.Add(this.cboCustomer);
            this.tabPage1.Controls.Add(this.lblFilms);
            this.tabPage1.Controls.Add(this.lvwFilms);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rent Film";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(319, 240);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(116, 35);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(34, 213);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(404, 21);
            this.cboCustomer.TabIndex = 2;
            // 
            // lblFilms
            // 
            this.lblFilms.AutoSize = true;
            this.lblFilms.Location = new System.Drawing.Point(34, 28);
            this.lblFilms.Name = "lblFilms";
            this.lblFilms.Size = new System.Drawing.Size(30, 13);
            this.lblFilms.TabIndex = 1;
            this.lblFilms.Text = "Films";
            // 
            // lvwFilms
            // 
            this.lvwFilms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitleFilms,
            this.colGenreFilms,
            this.colRentalDays});
            this.lvwFilms.FullRowSelect = true;
            this.lvwFilms.HideSelection = false;
            this.lvwFilms.Location = new System.Drawing.Point(34, 47);
            this.lvwFilms.Name = "lvwFilms";
            this.lvwFilms.Size = new System.Drawing.Size(404, 160);
            this.lvwFilms.TabIndex = 0;
            this.lvwFilms.UseCompatibleStateImageBehavior = false;
            this.lvwFilms.View = System.Windows.Forms.View.Details;
            // 
            // colTitleFilms
            // 
            this.colTitleFilms.Text = "Title";
            this.colTitleFilms.Width = 180;
            // 
            // colGenreFilms
            // 
            this.colGenreFilms.Text = "Genre";
            this.colGenreFilms.Width = 100;
            // 
            // colRentalDays
            // 
            this.colRentalDays.Text = "Rental Days";
            this.colRentalDays.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReturn);
            this.tabPage2.Controls.Add(this.dateTimePicker);
            this.tabPage2.Controls.Add(this.lblReturnDate);
            this.tabPage2.Controls.Add(this.lblBookings);
            this.tabPage2.Controls.Add(this.lvwBookings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(102, 232);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(107, 33);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 206);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(3, 190);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(65, 13);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Location = new System.Drawing.Point(6, 13);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(51, 13);
            this.lblBookings.TabIndex = 1;
            this.lblBookings.Text = "Bookings";
            // 
            // lvwBookings
            // 
            this.lvwBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomer,
            this.colTitle,
            this.colGenre,
            this.colRented,
            this.colReturned,
            this.colCost});
            this.lvwBookings.FullRowSelect = true;
            this.lvwBookings.HideSelection = false;
            this.lvwBookings.Location = new System.Drawing.Point(6, 29);
            this.lvwBookings.Name = "lvwBookings";
            this.lvwBookings.Size = new System.Drawing.Size(690, 146);
            this.lvwBookings.TabIndex = 0;
            this.lvwBookings.UseCompatibleStateImageBehavior = false;
            this.lvwBookings.View = System.Windows.Forms.View.Details;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 100;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 180;
            // 
            // colGenre
            // 
            this.colGenre.Text = "Genre";
            this.colGenre.Width = 100;
            // 
            // colRented
            // 
            this.colRented.Text = "Rented";
            this.colRented.Width = 115;
            // 
            // colReturned
            // 
            this.colReturned.Text = "Returned";
            this.colReturned.Width = 115;
            // 
            // colCost
            // 
            this.colCost.Text = "Cost";
            this.colCost.Width = 70;
            // 
            // tbpgMaintenance
            // 
            this.tbpgMaintenance.Controls.Add(this.groupBox3);
            this.tbpgMaintenance.Controls.Add(this.groupBox2);
            this.tbpgMaintenance.Controls.Add(this.groupBox1);
            this.tbpgMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tbpgMaintenance.Name = "tbpgMaintenance";
            this.tbpgMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgMaintenance.Size = new System.Drawing.Size(702, 379);
            this.tbpgMaintenance.TabIndex = 2;
            this.tbpgMaintenance.Text = "Maintenance";
            this.tbpgMaintenance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numVideosDays);
            this.groupBox3.Controls.Add(this.txtVideosName);
            this.groupBox3.Controls.Add(this.btnVideosAdd);
            this.groupBox3.Controls.Add(this.btnVideosUpdate);
            this.groupBox3.Controls.Add(this.btnVideosDelete);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cboVideosGenre);
            this.groupBox3.Controls.Add(this.cboVideosVideo);
            this.groupBox3.Location = new System.Drawing.Point(269, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 187);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Videos";
            // 
            // numVideosDays
            // 
            this.numVideosDays.Location = new System.Drawing.Point(138, 130);
            this.numVideosDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numVideosDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVideosDays.Name = "numVideosDays";
            this.numVideosDays.Size = new System.Drawing.Size(78, 20);
            this.numVideosDays.TabIndex = 13;
            this.numVideosDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtVideosName
            // 
            this.txtVideosName.Location = new System.Drawing.Point(6, 131);
            this.txtVideosName.Name = "txtVideosName";
            this.txtVideosName.Size = new System.Drawing.Size(121, 20);
            this.txtVideosName.TabIndex = 12;
            // 
            // btnVideosAdd
            // 
            this.btnVideosAdd.Location = new System.Drawing.Point(168, 157);
            this.btnVideosAdd.Name = "btnVideosAdd";
            this.btnVideosAdd.Size = new System.Drawing.Size(48, 23);
            this.btnVideosAdd.TabIndex = 11;
            this.btnVideosAdd.Text = "Add";
            this.btnVideosAdd.UseVisualStyleBackColor = true;
            this.btnVideosAdd.Click += new System.EventHandler(this.btnVideosAdd_Click);
            // 
            // btnVideosUpdate
            // 
            this.btnVideosUpdate.Location = new System.Drawing.Point(87, 156);
            this.btnVideosUpdate.Name = "btnVideosUpdate";
            this.btnVideosUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnVideosUpdate.TabIndex = 10;
            this.btnVideosUpdate.Text = "Update";
            this.btnVideosUpdate.UseVisualStyleBackColor = true;
            this.btnVideosUpdate.Click += new System.EventHandler(this.btnVideosUpdate_Click);
            // 
            // btnVideosDelete
            // 
            this.btnVideosDelete.Location = new System.Drawing.Point(6, 157);
            this.btnVideosDelete.Name = "btnVideosDelete";
            this.btnVideosDelete.Size = new System.Drawing.Size(75, 23);
            this.btnVideosDelete.TabIndex = 9;
            this.btnVideosDelete.Text = "Delete";
            this.btnVideosDelete.UseVisualStyleBackColor = true;
            this.btnVideosDelete.Click += new System.EventHandler(this.btnVideosDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Video";
            // 
            // cboVideosGenre
            // 
            this.cboVideosGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideosGenre.FormattingEnabled = true;
            this.cboVideosGenre.Location = new System.Drawing.Point(6, 79);
            this.cboVideosGenre.Name = "cboVideosGenre";
            this.cboVideosGenre.Size = new System.Drawing.Size(216, 21);
            this.cboVideosGenre.TabIndex = 3;
            // 
            // cboVideosVideo
            // 
            this.cboVideosVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideosVideo.FormattingEnabled = true;
            this.cboVideosVideo.Location = new System.Drawing.Point(6, 39);
            this.cboVideosVideo.Name = "cboVideosVideo";
            this.cboVideosVideo.Size = new System.Drawing.Size(216, 21);
            this.cboVideosVideo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomersLastName);
            this.groupBox2.Controls.Add(this.txtCustomersFirstName);
            this.groupBox2.Controls.Add(this.btnCustomersAdd);
            this.groupBox2.Controls.Add(this.btnCustomersUpdate);
            this.groupBox2.Controls.Add(this.btnCustomersDelete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboCustomersCustomer);
            this.groupBox2.Location = new System.Drawing.Point(23, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customers";
            // 
            // txtCustomersLastName
            // 
            this.txtCustomersLastName.Location = new System.Drawing.Point(7, 126);
            this.txtCustomersLastName.Name = "txtCustomersLastName";
            this.txtCustomersLastName.Size = new System.Drawing.Size(210, 20);
            this.txtCustomersLastName.TabIndex = 8;
            // 
            // txtCustomersFirstName
            // 
            this.txtCustomersFirstName.Location = new System.Drawing.Point(7, 86);
            this.txtCustomersFirstName.Name = "txtCustomersFirstName";
            this.txtCustomersFirstName.Size = new System.Drawing.Size(210, 20);
            this.txtCustomersFirstName.TabIndex = 6;
            // 
            // btnCustomersAdd
            // 
            this.btnCustomersAdd.Location = new System.Drawing.Point(169, 153);
            this.btnCustomersAdd.Name = "btnCustomersAdd";
            this.btnCustomersAdd.Size = new System.Drawing.Size(48, 23);
            this.btnCustomersAdd.TabIndex = 7;
            this.btnCustomersAdd.Text = "Add";
            this.btnCustomersAdd.UseVisualStyleBackColor = true;
            this.btnCustomersAdd.Click += new System.EventHandler(this.btnCustomersAdd_Click);
            // 
            // btnCustomersUpdate
            // 
            this.btnCustomersUpdate.Location = new System.Drawing.Point(88, 152);
            this.btnCustomersUpdate.Name = "btnCustomersUpdate";
            this.btnCustomersUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCustomersUpdate.TabIndex = 6;
            this.btnCustomersUpdate.Text = "Update";
            this.btnCustomersUpdate.UseVisualStyleBackColor = true;
            this.btnCustomersUpdate.Click += new System.EventHandler(this.btnCustomersUpdate_Click);
            // 
            // btnCustomersDelete
            // 
            this.btnCustomersDelete.Location = new System.Drawing.Point(7, 153);
            this.btnCustomersDelete.Name = "btnCustomersDelete";
            this.btnCustomersDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustomersDelete.TabIndex = 5;
            this.btnCustomersDelete.Text = "Delete";
            this.btnCustomersDelete.UseVisualStyleBackColor = true;
            this.btnCustomersDelete.Click += new System.EventHandler(this.btnCustomersDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // cboCustomersCustomer
            // 
            this.cboCustomersCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomersCustomer.FormattingEnabled = true;
            this.cboCustomersCustomer.Location = new System.Drawing.Point(7, 35);
            this.cboCustomersCustomer.Name = "cboCustomersCustomer";
            this.cboCustomersCustomer.Size = new System.Drawing.Size(210, 21);
            this.cboCustomersCustomer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGenresName);
            this.groupBox1.Controls.Add(this.btnGenresAdd);
            this.groupBox1.Controls.Add(this.btnGenresUpdate);
            this.groupBox1.Controls.Add(this.btnGenresDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboGenresGenre);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genres";
            // 
            // txtGenresName
            // 
            this.txtGenresName.Location = new System.Drawing.Point(7, 64);
            this.txtGenresName.Name = "txtGenresName";
            this.txtGenresName.Size = new System.Drawing.Size(210, 20);
            this.txtGenresName.TabIndex = 5;
            // 
            // btnGenresAdd
            // 
            this.btnGenresAdd.Location = new System.Drawing.Point(169, 99);
            this.btnGenresAdd.Name = "btnGenresAdd";
            this.btnGenresAdd.Size = new System.Drawing.Size(48, 23);
            this.btnGenresAdd.TabIndex = 4;
            this.btnGenresAdd.Text = "Add";
            this.btnGenresAdd.UseVisualStyleBackColor = true;
            this.btnGenresAdd.Click += new System.EventHandler(this.btnGenresAdd_Click);
            // 
            // btnGenresUpdate
            // 
            this.btnGenresUpdate.Location = new System.Drawing.Point(88, 98);
            this.btnGenresUpdate.Name = "btnGenresUpdate";
            this.btnGenresUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnGenresUpdate.TabIndex = 3;
            this.btnGenresUpdate.Text = "Update";
            this.btnGenresUpdate.UseVisualStyleBackColor = true;
            this.btnGenresUpdate.Click += new System.EventHandler(this.btnGenresUpdate_Click);
            // 
            // btnGenresDelete
            // 
            this.btnGenresDelete.Location = new System.Drawing.Point(7, 99);
            this.btnGenresDelete.Name = "btnGenresDelete";
            this.btnGenresDelete.Size = new System.Drawing.Size(75, 23);
            this.btnGenresDelete.TabIndex = 2;
            this.btnGenresDelete.Text = "Delete";
            this.btnGenresDelete.UseVisualStyleBackColor = true;
            this.btnGenresDelete.Click += new System.EventHandler(this.btnGenresDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // cboGenresGenre
            // 
            this.cboGenresGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenresGenre.FormattingEnabled = true;
            this.cboGenresGenre.Location = new System.Drawing.Point(7, 20);
            this.cboGenresGenre.Name = "cboGenresGenre";
            this.cboGenresGenre.Size = new System.Drawing.Size(210, 21);
            this.cboGenresGenre.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(622, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbctlVideoRental);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbctlVideoRental.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tbpgMaintenance.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVideosDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctlVideoRental;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbpgMaintenance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numVideosDays;
        private System.Windows.Forms.TextBox txtVideosName;
        private System.Windows.Forms.Button btnVideosAdd;
        private System.Windows.Forms.Button btnVideosUpdate;
        private System.Windows.Forms.Button btnVideosDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboVideosGenre;
        private System.Windows.Forms.ComboBox cboVideosVideo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomersLastName;
        private System.Windows.Forms.TextBox txtCustomersFirstName;
        private System.Windows.Forms.Button btnCustomersAdd;
        private System.Windows.Forms.Button btnCustomersUpdate;
        private System.Windows.Forms.Button btnCustomersDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomersCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGenresName;
        private System.Windows.Forms.Button btnGenresAdd;
        private System.Windows.Forms.Button btnGenresUpdate;
        private System.Windows.Forms.Button btnGenresDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGenresGenre;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblFilms;
        private System.Windows.Forms.ListView lvwFilms;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.ListView lvwBookings;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTitleFilms;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colGenre;
        private System.Windows.Forms.ColumnHeader colRented;
        private System.Windows.Forms.ColumnHeader colReturned;
        private System.Windows.Forms.ColumnHeader colCost;
        private System.Windows.Forms.ColumnHeader colGenreFilms;
        private System.Windows.Forms.ColumnHeader colRentalDays;
    }
}

