namespace HotelBooking.Views
{
    partial class BookingForm
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDtpStartPreFix = new System.Windows.Forms.Label();
            this.lblDtpEndPreFix = new System.Windows.Forms.Label();
            this.lblDgvAvailableRoomsPreFix = new System.Windows.Forms.Label();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.GuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDgvGuestsPreFix = new System.Windows.Forms.Label();
            this.dgvAvailableRooms = new System.Windows.Forms.DataGridView();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.pnlBookingInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblGuestsPreFix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblTotalBeds = new System.Windows.Forms.Label();
            this.lblTotalBedsPreFix = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomNumberPreFix = new System.Windows.Forms.Label();
            this.lblRoomDescription = new System.Windows.Forms.Label();
            this.lblRoomTypeDescPreFix = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPricePreFix = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblEndDatePreFix = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStartDatePreFix = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblGuestPreFix = new System.Windows.Forms.Label();
            this.cmbExtraBeds = new System.Windows.Forms.ComboBox();
            this.lblCmbExtraBedsPreFix = new System.Windows.Forms.Label();
            this.lblCmbGuestsPreFix = new System.Windows.Forms.Label();
            this.cmbGuests = new System.Windows.Forms.ComboBox();
            this.pnlPreviousBookingInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrevGuests = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPrevTotalBeds = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPrevRoomNumber = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPrevRoomDescription = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPrevPrice = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPrevEndDate = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblPrevStartDate = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblPrevGuest = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblUpdatedBooking = new System.Windows.Forms.Label();
            this.lblPreviousBooking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).BeginInit();
            this.pnlBookingInfo.SuspendLayout();
            this.pnlPreviousBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(114, 43);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(235, 22);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpAny_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(114, 83);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(235, 22);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpAny_ValueChanged);
            // 
            // lblDtpStartPreFix
            // 
            this.lblDtpStartPreFix.AutoSize = true;
            this.lblDtpStartPreFix.BackColor = System.Drawing.Color.Transparent;
            this.lblDtpStartPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDtpStartPreFix.Location = new System.Drawing.Point(30, 46);
            this.lblDtpStartPreFix.Name = "lblDtpStartPreFix";
            this.lblDtpStartPreFix.Size = new System.Drawing.Size(78, 16);
            this.lblDtpStartPreFix.TabIndex = 2;
            this.lblDtpStartPreFix.Text = "Incheckning";
            // 
            // lblDtpEndPreFix
            // 
            this.lblDtpEndPreFix.AutoSize = true;
            this.lblDtpEndPreFix.BackColor = System.Drawing.Color.Transparent;
            this.lblDtpEndPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDtpEndPreFix.Location = new System.Drawing.Point(27, 86);
            this.lblDtpEndPreFix.Name = "lblDtpEndPreFix";
            this.lblDtpEndPreFix.Size = new System.Drawing.Size(81, 16);
            this.lblDtpEndPreFix.TabIndex = 3;
            this.lblDtpEndPreFix.Text = "Utcheckning";
            // 
            // lblDgvAvailableRoomsPreFix
            // 
            this.lblDgvAvailableRoomsPreFix.AutoSize = true;
            this.lblDgvAvailableRoomsPreFix.BackColor = System.Drawing.Color.Transparent;
            this.lblDgvAvailableRoomsPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDgvAvailableRoomsPreFix.Location = new System.Drawing.Point(30, 144);
            this.lblDgvAvailableRoomsPreFix.Name = "lblDgvAvailableRoomsPreFix";
            this.lblDgvAvailableRoomsPreFix.Size = new System.Drawing.Size(103, 16);
            this.lblDgvAvailableRoomsPreFix.TabIndex = 5;
            this.lblDgvAvailableRoomsPreFix.Text = "Tillgängliga rum";
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToAddRows = false;
            this.dgvGuests.AllowUserToDeleteRows = false;
            this.dgvGuests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber});
            this.dgvGuests.Location = new System.Drawing.Point(33, 403);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowHeadersWidth = 51;
            this.dgvGuests.RowTemplate.Height = 24;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(661, 185);
            this.dgvGuests.TabIndex = 6;
            this.dgvGuests.SelectionChanged += new System.EventHandler(this.dgvGuests_SelectionChanged);
            // 
            // GuestID
            // 
            this.GuestID.DataPropertyName = "GuestID";
            this.GuestID.HeaderText = "";
            this.GuestID.MinimumWidth = 6;
            this.GuestID.Name = "GuestID";
            this.GuestID.ReadOnly = true;
            this.GuestID.Visible = false;
            this.GuestID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Förnamn";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Efternamn";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Telefon nr.";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // lblDgvGuestsPreFix
            // 
            this.lblDgvGuestsPreFix.AutoSize = true;
            this.lblDgvGuestsPreFix.BackColor = System.Drawing.Color.Transparent;
            this.lblDgvGuestsPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDgvGuestsPreFix.Location = new System.Drawing.Point(30, 384);
            this.lblDgvGuestsPreFix.Name = "lblDgvGuestsPreFix";
            this.lblDgvGuestsPreFix.Size = new System.Drawing.Size(119, 16);
            this.lblDgvGuestsPreFix.TabIndex = 7;
            this.lblDgvGuestsPreFix.Text = "Bokningen görs för";
            // 
            // dgvAvailableRooms
            // 
            this.dgvAvailableRooms.AllowUserToAddRows = false;
            this.dgvAvailableRooms.AllowUserToDeleteRows = false;
            this.dgvAvailableRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableRooms.Location = new System.Drawing.Point(33, 163);
            this.dgvAvailableRooms.MultiSelect = false;
            this.dgvAvailableRooms.Name = "dgvAvailableRooms";
            this.dgvAvailableRooms.ReadOnly = true;
            this.dgvAvailableRooms.RowHeadersWidth = 51;
            this.dgvAvailableRooms.RowTemplate.Height = 24;
            this.dgvAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableRooms.Size = new System.Drawing.Size(661, 185);
            this.dgvAvailableRooms.TabIndex = 8;
            this.dgvAvailableRooms.SelectionChanged += new System.EventHandler(this.dgvAvailableRooms_SelectionChanged);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(159, 367);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(134, 34);
            this.btnCreateBooking.TabIndex = 9;
            this.btnCreateBooking.Text = "Skapa bokning";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // pnlBookingInfo
            // 
            this.pnlBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlBookingInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookingInfo.Controls.Add(this.label6);
            this.pnlBookingInfo.Controls.Add(this.lblGuests);
            this.pnlBookingInfo.Controls.Add(this.lblGuestsPreFix);
            this.pnlBookingInfo.Controls.Add(this.label5);
            this.pnlBookingInfo.Controls.Add(this.label4);
            this.pnlBookingInfo.Controls.Add(this.label3);
            this.pnlBookingInfo.Controls.Add(this.label2);
            this.pnlBookingInfo.Controls.Add(this.label1);
            this.pnlBookingInfo.Controls.Add(this.lblLine1);
            this.pnlBookingInfo.Controls.Add(this.lblTotalBeds);
            this.pnlBookingInfo.Controls.Add(this.lblTotalBedsPreFix);
            this.pnlBookingInfo.Controls.Add(this.btnCancel);
            this.pnlBookingInfo.Controls.Add(this.lblRoomNumber);
            this.pnlBookingInfo.Controls.Add(this.lblRoomNumberPreFix);
            this.pnlBookingInfo.Controls.Add(this.lblRoomDescription);
            this.pnlBookingInfo.Controls.Add(this.lblRoomTypeDescPreFix);
            this.pnlBookingInfo.Controls.Add(this.lblPrice);
            this.pnlBookingInfo.Controls.Add(this.lblPricePreFix);
            this.pnlBookingInfo.Controls.Add(this.lblEndDate);
            this.pnlBookingInfo.Controls.Add(this.lblEndDatePreFix);
            this.pnlBookingInfo.Controls.Add(this.lblStartDate);
            this.pnlBookingInfo.Controls.Add(this.lblStartDatePreFix);
            this.pnlBookingInfo.Controls.Add(this.lblGuest);
            this.pnlBookingInfo.Controls.Add(this.lblGuestPreFix);
            this.pnlBookingInfo.Controls.Add(this.btnCreateBooking);
            this.pnlBookingInfo.Location = new System.Drawing.Point(709, 163);
            this.pnlBookingInfo.Name = "pnlBookingInfo";
            this.pnlBookingInfo.Size = new System.Drawing.Size(306, 425);
            this.pnlBookingInfo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(13, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 2);
            this.label6.TabIndex = 31;
            this.label6.Text = "label1";
            // 
            // lblGuests
            // 
            this.lblGuests.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuests.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuests.Location = new System.Drawing.Point(114, 79);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(179, 16);
            this.lblGuests.TabIndex = 30;
            this.lblGuests.Text = "label1";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGuestsPreFix
            // 
            this.lblGuestsPreFix.AutoSize = true;
            this.lblGuestsPreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestsPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuestsPreFix.Location = new System.Drawing.Point(15, 79);
            this.lblGuestsPreFix.Name = "lblGuestsPreFix";
            this.lblGuestsPreFix.Size = new System.Drawing.Size(57, 16);
            this.lblGuestsPreFix.TabIndex = 29;
            this.lblGuestsPreFix.Text = "Gäster:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(13, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 2);
            this.label5.TabIndex = 28;
            this.label5.Text = "label1";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 2);
            this.label4.TabIndex = 27;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 2);
            this.label3.TabIndex = 26;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 2);
            this.label2.TabIndex = 25;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 2);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // lblLine1
            // 
            this.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLine1.Location = new System.Drawing.Point(13, 35);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(280, 2);
            this.lblLine1.TabIndex = 13;
            this.lblLine1.Text = "label1";
            // 
            // lblTotalBeds
            // 
            this.lblTotalBeds.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalBeds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBeds.Location = new System.Drawing.Point(75, 110);
            this.lblTotalBeds.Name = "lblTotalBeds";
            this.lblTotalBeds.Size = new System.Drawing.Size(218, 16);
            this.lblTotalBeds.TabIndex = 23;
            this.lblTotalBeds.Text = "label1";
            this.lblTotalBeds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalBedsPreFix
            // 
            this.lblTotalBedsPreFix.AutoSize = true;
            this.lblTotalBedsPreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBedsPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBedsPreFix.Location = new System.Drawing.Point(15, 110);
            this.lblTotalBedsPreFix.Name = "lblTotalBedsPreFix";
            this.lblTotalBedsPreFix.Size = new System.Drawing.Size(61, 16);
            this.lblTotalBedsPreFix.TabIndex = 13;
            this.lblTotalBedsPreFix.Text = "Sängar:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 34);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoomNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRoomNumber.Location = new System.Drawing.Point(114, 205);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(179, 16);
            this.lblRoomNumber.TabIndex = 21;
            this.lblRoomNumber.Text = "label1";
            this.lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomNumberPreFix
            // 
            this.lblRoomNumberPreFix.AutoSize = true;
            this.lblRoomNumberPreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumberPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRoomNumberPreFix.Location = new System.Drawing.Point(15, 205);
            this.lblRoomNumberPreFix.Name = "lblRoomNumberPreFix";
            this.lblRoomNumberPreFix.Size = new System.Drawing.Size(104, 16);
            this.lblRoomNumberPreFix.TabIndex = 20;
            this.lblRoomNumberPreFix.Text = "Rumsnummer:";
            // 
            // lblRoomDescription
            // 
            this.lblRoomDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoomDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRoomDescription.Location = new System.Drawing.Point(98, 173);
            this.lblRoomDescription.Name = "lblRoomDescription";
            this.lblRoomDescription.Size = new System.Drawing.Size(195, 16);
            this.lblRoomDescription.TabIndex = 19;
            this.lblRoomDescription.Text = "label1";
            this.lblRoomDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomTypeDescPreFix
            // 
            this.lblRoomTypeDescPreFix.AutoSize = true;
            this.lblRoomTypeDescPreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomTypeDescPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRoomTypeDescPreFix.Location = new System.Drawing.Point(15, 173);
            this.lblRoomTypeDescPreFix.Name = "lblRoomTypeDescPreFix";
            this.lblRoomTypeDescPreFix.Size = new System.Drawing.Size(88, 16);
            this.lblRoomTypeDescPreFix.TabIndex = 18;
            this.lblRoomTypeDescPreFix.Text = "Typ av rum:";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(61, 141);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(232, 16);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "label1";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPricePreFix
            // 
            this.lblPricePreFix.AutoSize = true;
            this.lblPricePreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPricePreFix.Location = new System.Drawing.Point(15, 141);
            this.lblPricePreFix.Name = "lblPricePreFix";
            this.lblPricePreFix.Size = new System.Drawing.Size(38, 16);
            this.lblPricePreFix.TabIndex = 16;
            this.lblPricePreFix.Text = "Pris:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEndDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndDate.Location = new System.Drawing.Point(222, 50);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 16);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "2022-11-20";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndDatePreFix
            // 
            this.lblEndDatePreFix.AutoSize = true;
            this.lblEndDatePreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDatePreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndDatePreFix.Location = new System.Drawing.Point(188, 50);
            this.lblEndDatePreFix.Name = "lblEndDatePreFix";
            this.lblEndDatePreFix.Size = new System.Drawing.Size(33, 16);
            this.lblEndDatePreFix.TabIndex = 14;
            this.lblEndDatePreFix.Text = "Till:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartDate.Location = new System.Drawing.Point(58, 50);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(44, 16);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "label3";
            // 
            // lblStartDatePreFix
            // 
            this.lblStartDatePreFix.AutoSize = true;
            this.lblStartDatePreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDatePreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartDatePreFix.Location = new System.Drawing.Point(15, 50);
            this.lblStartDatePreFix.Name = "lblStartDatePreFix";
            this.lblStartDatePreFix.Size = new System.Drawing.Size(42, 16);
            this.lblStartDatePreFix.TabIndex = 12;
            this.lblStartDatePreFix.Text = "Från:";
            // 
            // lblGuest
            // 
            this.lblGuest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuest.Location = new System.Drawing.Point(154, 18);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGuest.Size = new System.Drawing.Size(139, 16);
            this.lblGuest.TabIndex = 11;
            this.lblGuest.Text = "namn";
            this.lblGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGuestPreFix
            // 
            this.lblGuestPreFix.AutoSize = true;
            this.lblGuestPreFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuestPreFix.Location = new System.Drawing.Point(15, 18);
            this.lblGuestPreFix.Name = "lblGuestPreFix";
            this.lblGuestPreFix.Size = new System.Drawing.Size(152, 16);
            this.lblGuestPreFix.TabIndex = 10;
            this.lblGuestPreFix.Text = "Bokningsinnehavare:";
            // 
            // cmbExtraBeds
            // 
            this.cmbExtraBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtraBeds.FormattingEnabled = true;
            this.cmbExtraBeds.Location = new System.Drawing.Point(573, 43);
            this.cmbExtraBeds.Name = "cmbExtraBeds";
            this.cmbExtraBeds.Size = new System.Drawing.Size(121, 24);
            this.cmbExtraBeds.TabIndex = 11;
            this.cmbExtraBeds.SelectedIndexChanged += new System.EventHandler(this.cmbExtraBeds_SelectedIndexChanged);
            // 
            // lblCmbExtraBedsPreFix
            // 
            this.lblCmbExtraBedsPreFix.AutoSize = true;
            this.lblCmbExtraBedsPreFix.BackColor = System.Drawing.Color.Transparent;
            this.lblCmbExtraBedsPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCmbExtraBedsPreFix.Location = new System.Drawing.Point(488, 47);
            this.lblCmbExtraBedsPreFix.Name = "lblCmbExtraBedsPreFix";
            this.lblCmbExtraBedsPreFix.Size = new System.Drawing.Size(79, 16);
            this.lblCmbExtraBedsPreFix.TabIndex = 12;
            this.lblCmbExtraBedsPreFix.Text = "Extrasängar";
            // 
            // lblCmbGuestsPreFix
            // 
            this.lblCmbGuestsPreFix.AutoSize = true;
            this.lblCmbGuestsPreFix.BackColor = System.Drawing.Color.Transparent;
            this.lblCmbGuestsPreFix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCmbGuestsPreFix.Location = new System.Drawing.Point(488, 86);
            this.lblCmbGuestsPreFix.Name = "lblCmbGuestsPreFix";
            this.lblCmbGuestsPreFix.Size = new System.Drawing.Size(78, 16);
            this.lblCmbGuestsPreFix.TabIndex = 14;
            this.lblCmbGuestsPreFix.Text = "Antal gäster";
            // 
            // cmbGuests
            // 
            this.cmbGuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuests.FormattingEnabled = true;
            this.cmbGuests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbGuests.Location = new System.Drawing.Point(573, 83);
            this.cmbGuests.Name = "cmbGuests";
            this.cmbGuests.Size = new System.Drawing.Size(121, 24);
            this.cmbGuests.TabIndex = 13;
            this.cmbGuests.SelectedIndexChanged += new System.EventHandler(this.cmbPeople_SelectedIndexChanged);
            // 
            // pnlPreviousBookingInfo
            // 
            this.pnlPreviousBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlPreviousBookingInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreviousBookingInfo.Controls.Add(this.label7);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevGuests);
            this.pnlPreviousBookingInfo.Controls.Add(this.label9);
            this.pnlPreviousBookingInfo.Controls.Add(this.label10);
            this.pnlPreviousBookingInfo.Controls.Add(this.label11);
            this.pnlPreviousBookingInfo.Controls.Add(this.label12);
            this.pnlPreviousBookingInfo.Controls.Add(this.label13);
            this.pnlPreviousBookingInfo.Controls.Add(this.label14);
            this.pnlPreviousBookingInfo.Controls.Add(this.label15);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevTotalBeds);
            this.pnlPreviousBookingInfo.Controls.Add(this.label17);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevRoomNumber);
            this.pnlPreviousBookingInfo.Controls.Add(this.label19);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevRoomDescription);
            this.pnlPreviousBookingInfo.Controls.Add(this.label21);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevPrice);
            this.pnlPreviousBookingInfo.Controls.Add(this.label23);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevEndDate);
            this.pnlPreviousBookingInfo.Controls.Add(this.label25);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevStartDate);
            this.pnlPreviousBookingInfo.Controls.Add(this.label27);
            this.pnlPreviousBookingInfo.Controls.Add(this.lblPrevGuest);
            this.pnlPreviousBookingInfo.Controls.Add(this.label29);
            this.pnlPreviousBookingInfo.Location = new System.Drawing.Point(1032, 163);
            this.pnlPreviousBookingInfo.Name = "pnlPreviousBookingInfo";
            this.pnlPreviousBookingInfo.Size = new System.Drawing.Size(306, 425);
            this.pnlPreviousBookingInfo.TabIndex = 32;
            this.pnlPreviousBookingInfo.Visible = false;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(13, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 2);
            this.label7.TabIndex = 31;
            this.label7.Text = "label1";
            // 
            // lblPrevGuests
            // 
            this.lblPrevGuests.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevGuests.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevGuests.Location = new System.Drawing.Point(114, 79);
            this.lblPrevGuests.Name = "lblPrevGuests";
            this.lblPrevGuests.Size = new System.Drawing.Size(179, 16);
            this.lblPrevGuests.TabIndex = 30;
            this.lblPrevGuests.Text = "label1";
            this.lblPrevGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(15, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Gäster:";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(13, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 2);
            this.label10.TabIndex = 28;
            this.label10.Text = "label1";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(13, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 2);
            this.label11.TabIndex = 27;
            this.label11.Text = "label1";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(13, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 2);
            this.label12.TabIndex = 26;
            this.label12.Text = "label1";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(13, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(280, 2);
            this.label13.TabIndex = 25;
            this.label13.Text = "label1";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(13, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 2);
            this.label14.TabIndex = 24;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(13, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 2);
            this.label15.TabIndex = 13;
            this.label15.Text = "label1";
            // 
            // lblPrevTotalBeds
            // 
            this.lblPrevTotalBeds.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevTotalBeds.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevTotalBeds.Location = new System.Drawing.Point(75, 110);
            this.lblPrevTotalBeds.Name = "lblPrevTotalBeds";
            this.lblPrevTotalBeds.Size = new System.Drawing.Size(218, 16);
            this.lblPrevTotalBeds.TabIndex = 23;
            this.lblPrevTotalBeds.Text = "label1";
            this.lblPrevTotalBeds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(15, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Sängar:";
            // 
            // lblPrevRoomNumber
            // 
            this.lblPrevRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevRoomNumber.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevRoomNumber.Location = new System.Drawing.Point(114, 205);
            this.lblPrevRoomNumber.Name = "lblPrevRoomNumber";
            this.lblPrevRoomNumber.Size = new System.Drawing.Size(179, 16);
            this.lblPrevRoomNumber.TabIndex = 21;
            this.lblPrevRoomNumber.Text = "label1";
            this.lblPrevRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(15, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "Rumsnummer:";
            // 
            // lblPrevRoomDescription
            // 
            this.lblPrevRoomDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevRoomDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevRoomDescription.Location = new System.Drawing.Point(98, 173);
            this.lblPrevRoomDescription.Name = "lblPrevRoomDescription";
            this.lblPrevRoomDescription.Size = new System.Drawing.Size(195, 16);
            this.lblPrevRoomDescription.TabIndex = 19;
            this.lblPrevRoomDescription.Text = "label1";
            this.lblPrevRoomDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(15, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Typ av rum:";
            // 
            // lblPrevPrice
            // 
            this.lblPrevPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevPrice.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevPrice.Location = new System.Drawing.Point(61, 141);
            this.lblPrevPrice.Name = "lblPrevPrice";
            this.lblPrevPrice.Size = new System.Drawing.Size(232, 16);
            this.lblPrevPrice.TabIndex = 17;
            this.lblPrevPrice.Text = "label1";
            this.lblPrevPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(15, 141);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 16);
            this.label23.TabIndex = 16;
            this.label23.Text = "Pris:";
            // 
            // lblPrevEndDate
            // 
            this.lblPrevEndDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevEndDate.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevEndDate.Location = new System.Drawing.Point(222, 50);
            this.lblPrevEndDate.Name = "lblPrevEndDate";
            this.lblPrevEndDate.Size = new System.Drawing.Size(71, 16);
            this.lblPrevEndDate.TabIndex = 15;
            this.lblPrevEndDate.Text = "2022-11-20";
            this.lblPrevEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Silver;
            this.label25.Location = new System.Drawing.Point(188, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 16);
            this.label25.TabIndex = 14;
            this.label25.Text = "Till:";
            // 
            // lblPrevStartDate
            // 
            this.lblPrevStartDate.AutoSize = true;
            this.lblPrevStartDate.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevStartDate.Location = new System.Drawing.Point(58, 50);
            this.lblPrevStartDate.Name = "lblPrevStartDate";
            this.lblPrevStartDate.Size = new System.Drawing.Size(44, 16);
            this.lblPrevStartDate.TabIndex = 13;
            this.lblPrevStartDate.Text = "label3";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Silver;
            this.label27.Location = new System.Drawing.Point(15, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 16);
            this.label27.TabIndex = 12;
            this.label27.Text = "Från:";
            // 
            // lblPrevGuest
            // 
            this.lblPrevGuest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrevGuest.ForeColor = System.Drawing.Color.Silver;
            this.lblPrevGuest.Location = new System.Drawing.Point(154, 18);
            this.lblPrevGuest.Name = "lblPrevGuest";
            this.lblPrevGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrevGuest.Size = new System.Drawing.Size(139, 16);
            this.lblPrevGuest.TabIndex = 11;
            this.lblPrevGuest.Text = "namn";
            this.lblPrevGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Silver;
            this.label29.Location = new System.Drawing.Point(15, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(152, 16);
            this.label29.TabIndex = 10;
            this.label29.Text = "Bokningsinnehavare:";
            // 
            // lblUpdatedBooking
            // 
            this.lblUpdatedBooking.AutoSize = true;
            this.lblUpdatedBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdatedBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUpdatedBooking.Location = new System.Drawing.Point(732, 117);
            this.lblUpdatedBooking.Name = "lblUpdatedBooking";
            this.lblUpdatedBooking.Size = new System.Drawing.Size(271, 32);
            this.lblUpdatedBooking.TabIndex = 33;
            this.lblUpdatedBooking.Text = "Uppdaterad bokning";
            // 
            // lblPreviousBooking
            // 
            this.lblPreviousBooking.AutoSize = true;
            this.lblPreviousBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviousBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPreviousBooking.Location = new System.Drawing.Point(1055, 117);
            this.lblPreviousBooking.Name = "lblPreviousBooking";
            this.lblPreviousBooking.Size = new System.Drawing.Size(268, 32);
            this.lblPreviousBooking.TabIndex = 34;
            this.lblPreviousBooking.Text = "Ursprunglig bokning";
            // 
            // BookingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::HotelBooking.Properties.Resources.cool_background__8_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 653);
            this.Controls.Add(this.lblPreviousBooking);
            this.Controls.Add(this.lblUpdatedBooking);
            this.Controls.Add(this.pnlPreviousBookingInfo);
            this.Controls.Add(this.lblCmbGuestsPreFix);
            this.Controls.Add(this.cmbGuests);
            this.Controls.Add(this.lblCmbExtraBedsPreFix);
            this.Controls.Add(this.cmbExtraBeds);
            this.Controls.Add(this.pnlBookingInfo);
            this.Controls.Add(this.dgvAvailableRooms);
            this.Controls.Add(this.lblDgvGuestsPreFix);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.lblDgvAvailableRoomsPreFix);
            this.Controls.Add(this.lblDtpEndPreFix);
            this.Controls.Add(this.lblDtpStartPreFix);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.DoubleBuffered = true;
            this.Name = "BookingForm";
            this.Text = "Skapa ny bokning";
            this.Shown += new System.EventHandler(this.BookingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).EndInit();
            this.pnlBookingInfo.ResumeLayout(false);
            this.pnlBookingInfo.PerformLayout();
            this.pnlPreviousBookingInfo.ResumeLayout(false);
            this.pnlPreviousBookingInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDtpStartPreFix;
        private System.Windows.Forms.Label lblDtpEndPreFix;
        private System.Windows.Forms.Label lblDgvAvailableRoomsPreFix;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Label lblDgvGuestsPreFix;
        private System.Windows.Forms.DataGridView dgvAvailableRooms;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Panel pnlBookingInfo;
        private System.Windows.Forms.Label lblGuestPreFix;
        private System.Windows.Forms.Label lblStartDatePreFix;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomNumberPreFix;
        private System.Windows.Forms.Label lblRoomDescription;
        private System.Windows.Forms.Label lblRoomTypeDescPreFix;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPricePreFix;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEndDatePreFix;
        private System.Windows.Forms.ComboBox cmbExtraBeds;
        private System.Windows.Forms.Label lblCmbExtraBedsPreFix;
        private System.Windows.Forms.Label lblTotalBeds;
        private System.Windows.Forms.Label lblTotalBedsPreFix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblCmbGuestsPreFix;
        private System.Windows.Forms.ComboBox cmbGuests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblGuestsPreFix;
        private System.Windows.Forms.Panel pnlPreviousBookingInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrevGuests;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPrevTotalBeds;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPrevRoomNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPrevRoomDescription;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPrevPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPrevEndDate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblPrevStartDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblPrevGuest;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblUpdatedBooking;
        private System.Windows.Forms.Label lblPreviousBooking;
    }
}