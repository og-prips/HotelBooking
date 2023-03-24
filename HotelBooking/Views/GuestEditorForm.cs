using System;
using System.Linq;
using System.Windows.Forms;
using HotelBooking.Models;
using HotelBooking.Repository;

namespace HotelBooking.Views
{
    public partial class GuestEditorForm : Form
    {
        private Guest _originalGuest;
        private GuestRepo _guestRepo;

        public GuestEditorForm()
        {
            InitializeComponent();

            _guestRepo = new GuestRepo();
        }

        public GuestEditorForm(Guest guest) 
        {
            InitializeComponent();

            _guestRepo = new GuestRepo();
            _originalGuest = guest;

            Text = "Uppdatera användare";
            btnEdit.Text = "Uppdatera";
            txtFirstName.Text = _originalGuest.FirstName;
            txtLastName.Text = _originalGuest.LastName;
            txtEmail.Text = _originalGuest.Email;
            txtPhoneNumber.Text = _originalGuest.PhoneNumber;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Var god fyll i alla uppgifter");
                return;
            }

            if (_originalGuest == null)
            {
                CreateGuest();
                MessageBox.Show($"Användare {txtFirstName.Text} skapad");
                this.Close();
            }
            else
            {
                UpdateGuest();
                MessageBox.Show($"Användare {txtFirstName.Text} uppdaterad");
                this.Close();
            }
        }

        private void CreateGuest()
        {
            var guest = new Guest();

            guest.FirstName = txtFirstName.Text;
            guest.LastName = txtLastName.Text;
            guest.Email = txtEmail.Text;
            guest.PhoneNumber = txtPhoneNumber.Text;

            _guestRepo.InsertGuest(guest);
        }

        private void UpdateGuest() 
        {
            _originalGuest.FirstName= txtFirstName.Text;
            _originalGuest.LastName = txtLastName.Text;
            _originalGuest.Email = txtEmail.Text;
            _originalGuest.PhoneNumber = txtPhoneNumber.Text;

            _guestRepo.UpdateGuest(_originalGuest);
        }

        private bool ValidateInput()
        {
            foreach (var txtBox in Controls.OfType<TextBox>())
            {
                txtBox.Text = txtBox.Text.Trim();
                if (txtBox.Text == string.Empty) return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
