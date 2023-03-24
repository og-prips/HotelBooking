using HotelBooking.Repository;
using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelBooking.Views
{
    public partial class MainForm : Form
    {
        private int _selectedBookingID;
        private BookingRepo _bookingRepo;
        private List<Booking> _allBookings;
        private DateTime _currentDate;

        public const int DaysToPay = 10;

        public MainForm()
        {
            _bookingRepo = new BookingRepo();

            InitializeComponent();
            SetBookingsView();
        }

        private void CheckInvoiceStatus()
        {
            foreach (var booking in _allBookings)
            {
                if (booking.Invoice.InvoiceDate.AddDays(DaysToPay) < _currentDate &&
                    !booking.Invoice.IsPaid)
                {
                    booking.IsCancelled = true;
                }
                else
                {
                    booking.IsCancelled = false;
                }

                _bookingRepo.UpdateBooking(booking);
            }
        }

        private void SetBookingsView()
        {
            UpdateBookingsView();

            dgvAllBookings.Columns["BookingID"].Visible = false;
            dgvAllBookings.Columns["InvoiceID"].Visible = false;

            dgvAllBookings.Columns["PhoneNumber"].HeaderText = "Telefon nr.";
            dgvAllBookings.Columns["StartDate"].HeaderText = "Incheckning";
            dgvAllBookings.Columns["EndDate"].HeaderText = "Utcheckning";
            dgvAllBookings.Columns["Number"].HeaderText = "Rums nr.";
            dgvAllBookings.Columns["IsCancelled"].HeaderText = "Annulerad";
            dgvAllBookings.Columns["IsPaid"].HeaderText = "Betalad";
        }

        private void UpdateBookingsView()
        {
            _bookingRepo = new BookingRepo();
            _allBookings = _bookingRepo.GetAllBookings().OrderBy(booking => booking.StartDate).ToList();

            dgvAllBookings.DataSource = _allBookings.Select(booking => new
            {
                booking.BookingID,
                booking.InvoiceID,
                booking.Guest.Email,
                booking.Guest.PhoneNumber,
                booking.StartDate,
                booking.EndDate,
                booking.Room.Number,
                booking.IsCancelled,
                booking.Invoice.IsPaid
            }).ToList();
        }

        private void btnManageGuests_Click(object sender, EventArgs e)
        {
            var frmGuestManager = new GuestManagerForm();
            frmGuestManager.ShowDialog();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            var frmBooking = new BookingForm();
            frmBooking.ShowDialog();
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            var booking = _bookingRepo.GetBooking((int)dgvAllBookings.CurrentRow.Cells["BookingID"].Value);
            var frmBooking = new BookingForm(booking);

            frmBooking.ShowDialog();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvAllBookings.CurrentRow == null) return;

            var room = dgvAllBookings.CurrentRow.Cells["Number"].Value;
            var startDate = (DateTime)dgvAllBookings.CurrentRow.Cells["StartDate"].Value;
            var endDate = (DateTime)dgvAllBookings.CurrentRow.Cells["EndDate"].Value;

            _bookingRepo.DeleteBooking(_selectedBookingID);

            MessageBox.Show($"Bokning för rum {room}\r" +
                $"mellan {startDate.ToString("yyyy-MM-dd")} och {endDate.ToString("yyyy-MM-dd")} borttagen");

            UpdateBookingsView();
        }

        private void dgvAllBookings_SelectionChanged(object sender, EventArgs e)
        {
            _selectedBookingID = (int)dgvAllBookings.CurrentRow.Cells["BookingID"].Value;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckInvoiceStatus();
            UpdateBookingsView();
        }

        private void btnShowInvoice_Click(object sender, EventArgs e)
        {
            var invoiceRepo = new InvoiceRepo();
            var invoice = invoiceRepo.GetInvoice((int)dgvAllBookings.CurrentRow.Cells["InvoiceID"].Value);
            
            var bookingRepo = new BookingRepo();
            var booking = bookingRepo.GetBooking((int)dgvAllBookings.CurrentRow.Cells["BookingID"].Value);
            
            var frmInvoice = new InvoiceForm(invoice, booking);

            frmInvoice.ShowDialog();
        }

        private void btnSimulateTime_Click(object sender, EventArgs e)
        {
            _currentDate = dtpSimulate.Value.Date;
        }
    }
}
