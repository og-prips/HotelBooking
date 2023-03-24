namespace HotelBooking.Views
{
    partial class MainForm
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
            this.btnManageGuests = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.dgvAllBookings = new System.Windows.Forms.DataGridView();
            this.lblAllBookings = new System.Windows.Forms.Label();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowInvoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSimulateTime = new System.Windows.Forms.Button();
            this.dtpSimulate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageGuests
            // 
            this.btnManageGuests.Location = new System.Drawing.Point(20, 21);
            this.btnManageGuests.Name = "btnManageGuests";
            this.btnManageGuests.Size = new System.Drawing.Size(201, 32);
            this.btnManageGuests.TabIndex = 0;
            this.btnManageGuests.Text = "Hantera gäster";
            this.btnManageGuests.UseVisualStyleBackColor = true;
            this.btnManageGuests.Click += new System.EventHandler(this.btnManageGuests_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(20, 76);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(201, 32);
            this.btnCreateBooking.TabIndex = 1;
            this.btnCreateBooking.Text = "Skapa ny bokning";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // dgvAllBookings
            // 
            this.dgvAllBookings.AllowUserToAddRows = false;
            this.dgvAllBookings.AllowUserToDeleteRows = false;
            this.dgvAllBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBookings.Location = new System.Drawing.Point(24, 46);
            this.dgvAllBookings.MultiSelect = false;
            this.dgvAllBookings.Name = "dgvAllBookings";
            this.dgvAllBookings.ReadOnly = true;
            this.dgvAllBookings.RowHeadersWidth = 51;
            this.dgvAllBookings.RowTemplate.Height = 24;
            this.dgvAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllBookings.Size = new System.Drawing.Size(783, 386);
            this.dgvAllBookings.TabIndex = 2;
            this.dgvAllBookings.SelectionChanged += new System.EventHandler(this.dgvAllBookings_SelectionChanged);
            // 
            // lblAllBookings
            // 
            this.lblAllBookings.AutoSize = true;
            this.lblAllBookings.BackColor = System.Drawing.Color.Transparent;
            this.lblAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBookings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllBookings.Location = new System.Drawing.Point(19, 14);
            this.lblAllBookings.Name = "lblAllBookings";
            this.lblAllBookings.Size = new System.Drawing.Size(166, 29);
            this.lblAllBookings.TabIndex = 3;
            this.lblAllBookings.Text = "Alla bokningar";
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(20, 114);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(201, 32);
            this.btnUpdateBooking.TabIndex = 4;
            this.btnUpdateBooking.Text = "Ändra vald bokning";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(20, 152);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(201, 32);
            this.btnDeleteBooking.TabIndex = 5;
            this.btnDeleteBooking.Text = "Ta bort vald bokning";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::HotelBooking.Properties.Resources.refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(813, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowInvoice
            // 
            this.btnShowInvoice.Location = new System.Drawing.Point(20, 212);
            this.btnShowInvoice.Name = "btnShowInvoice";
            this.btnShowInvoice.Size = new System.Drawing.Size(201, 32);
            this.btnShowInvoice.TabIndex = 7;
            this.btnShowInvoice.Text = "Visa faktura för vald bokning";
            this.btnShowInvoice.UseVisualStyleBackColor = true;
            this.btnShowInvoice.Click += new System.EventHandler(this.btnShowInvoice_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(897, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 386);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnManageGuests);
            this.panel2.Controls.Add(this.btnDeleteBooking);
            this.panel2.Controls.Add(this.btnCreateBooking);
            this.panel2.Controls.Add(this.btnUpdateBooking);
            this.panel2.Controls.Add(this.btnShowInvoice);
            this.panel2.Location = new System.Drawing.Point(24, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 270);
            this.panel2.TabIndex = 9;
            // 
            // btnSimulateTime
            // 
            this.btnSimulateTime.Location = new System.Drawing.Point(65, 34);
            this.btnSimulateTime.Name = "btnSimulateTime";
            this.btnSimulateTime.Size = new System.Drawing.Size(107, 23);
            this.btnSimulateTime.TabIndex = 9;
            this.btnSimulateTime.Text = "Simulera tid";
            this.btnSimulateTime.UseVisualStyleBackColor = true;
            this.btnSimulateTime.Click += new System.EventHandler(this.btnSimulateTime_Click);
            // 
            // dtpSimulate
            // 
            this.dtpSimulate.Location = new System.Drawing.Point(20, 6);
            this.dtpSimulate.Name = "dtpSimulate";
            this.dtpSimulate.Size = new System.Drawing.Size(200, 22);
            this.dtpSimulate.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSimulateTime);
            this.panel3.Controls.Add(this.dtpSimulate);
            this.panel3.Location = new System.Drawing.Point(24, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 67);
            this.panel3.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::HotelBooking.Properties.Resources.cool_background__8_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblAllBookings);
            this.Controls.Add(this.dgvAllBookings);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Hantera hotellbokningar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageGuests;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.DataGridView dgvAllBookings;
        private System.Windows.Forms.Label lblAllBookings;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSimulateTime;
        private System.Windows.Forms.DateTimePicker dtpSimulate;
        private System.Windows.Forms.Panel panel3;
    }
}