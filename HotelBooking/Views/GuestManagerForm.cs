using HotelBooking.Repository;
using System;
using System.Windows.Forms;

namespace HotelBooking.Views
{
    public partial class GuestManagerForm : Form
    {
        private int _selectedGuestID;
        private GuestEditorForm _frmGuestEditor;
        private GuestRepo _guestRepo;

        public GuestManagerForm()
        {
            _guestRepo = new GuestRepo();
            
            InitializeComponent();
            SetGuestView();
        }

        private void SetGuestView()
        {
            dgvGuests.DataSource = _guestRepo.GetAllGuests();
            dgvGuests.Columns["Bookings"].Visible = false;
        }

        private void btnCreateGuest_Click(object sender, EventArgs e)
        {
            _frmGuestEditor = new GuestEditorForm();
            _frmGuestEditor.ShowDialog();
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            _frmGuestEditor = new GuestEditorForm(_guestRepo.GetGuest(_selectedGuestID));
            _frmGuestEditor.ShowDialog();
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (_guestRepo.GuestHasBookings(_selectedGuestID))
            {
                MessageBox.Show("Denna gäst innehar bokningar, vänligen ta bort dessa och försök igen");
            }
            else
            {
                _guestRepo.DeleteGuest(_selectedGuestID);

                var guestName = dgvGuests.CurrentRow.Cells["FirstName"].Value.ToString() +
                " " +
                dgvGuests.CurrentRow.Cells["LastName"].Value.ToString();

                MessageBox.Show($"Användare {guestName} raderad");
            }
        }

        private void dgvGuests_SelectionChanged(object sender, EventArgs e)
        {
            _selectedGuestID = (int)dgvGuests.CurrentRow.Cells["GuestID"].Value;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetGuestView();
        }
    }
}
