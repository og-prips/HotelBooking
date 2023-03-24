namespace HotelBooking.Views
{
    partial class GuestManagerForm
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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.GuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateGuest = new System.Windows.Forms.Button();
            this.btnUpdateGuest = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToAddRows = false;
            this.dgvGuests.AllowUserToDeleteRows = false;
            this.dgvGuests.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber});
            this.dgvGuests.Location = new System.Drawing.Point(12, 28);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowHeadersWidth = 51;
            this.dgvGuests.RowTemplate.Height = 24;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(665, 234);
            this.dgvGuests.TabIndex = 0;
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
            // btnCreateGuest
            // 
            this.btnCreateGuest.Location = new System.Drawing.Point(750, 94);
            this.btnCreateGuest.Name = "btnCreateGuest";
            this.btnCreateGuest.Size = new System.Drawing.Size(180, 33);
            this.btnCreateGuest.TabIndex = 1;
            this.btnCreateGuest.Text = "Lägg till ny gäst";
            this.btnCreateGuest.UseVisualStyleBackColor = true;
            this.btnCreateGuest.Click += new System.EventHandler(this.btnCreateGuest_Click);
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.Location = new System.Drawing.Point(750, 133);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(180, 33);
            this.btnUpdateGuest.TabIndex = 2;
            this.btnUpdateGuest.Text = "Uppdatera vald gäst";
            this.btnUpdateGuest.UseVisualStyleBackColor = true;
            this.btnUpdateGuest.Click += new System.EventHandler(this.btnUpdateGuest_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(750, 172);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(180, 33);
            this.btnDeleteGuest.TabIndex = 3;
            this.btnDeleteGuest.Text = "Ta bort vald gäst";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::HotelBooking.Properties.Resources.refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(683, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 38);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GuestManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::HotelBooking.Properties.Resources.cool_background__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 290);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.btnUpdateGuest);
            this.Controls.Add(this.btnCreateGuest);
            this.Controls.Add(this.dgvGuests);
            this.Name = "GuestManagerForm";
            this.Text = "Gästhanteraren";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button btnCreateGuest;
        private System.Windows.Forms.Button btnUpdateGuest;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Button btnRefresh;
    }
}