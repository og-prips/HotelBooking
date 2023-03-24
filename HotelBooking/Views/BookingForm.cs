using HotelBooking.Models;
using HotelBooking.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelBooking.Views
{
	public partial class BookingForm : Form
	{
		private int _selectedGuestID;
		private int _selectedRoomID;

		private BookingRepo _bookingRepo;
		private GuestRepo _guestRepo;
		private RoomRepo _roomRepo;
		private InvoiceRepo _invoiceRepo;

		private Booking _updateBooking;
		
		public BookingForm()
		{
			SetCommonParameters();
			Width = 1060;
		}

		public BookingForm(Booking booking)
		{
			_updateBooking = booking;
			
			SetCommonParameters();
			SetUpdateForm(_updateBooking);
		}

		private void SetCommonParameters()
		{
            _bookingRepo = new BookingRepo();
            _guestRepo = new GuestRepo();
            _roomRepo = new RoomRepo();
            _invoiceRepo = new InvoiceRepo();

            InitializeComponent();
            UpdateDateTimePickers();
            SetAvailableRoomsView();
            SetGuestView();

            cmbGuests.SelectedIndex = 0;
        }

		private void SetUpdateForm(Booking booking)
		{
            Width = 1375;
            Text = "Uppdatera en bokning";
            btnCreateBooking.Text = "Uppdatera bokning";
            dtpStartDate.Value = _updateBooking.StartDate;
            dtpEndDate.Value = _updateBooking.EndDate;

			SetPreviousBookingInfo(booking);
        }

		private void SetPreviousBookingInfo(Booking booking)
		{
			var prevExtraBeds = booking.TotalBeds - booking.Room.RoomType.Beds;

			pnlPreviousBookingInfo.Visible = true;
			lblPrevGuest.Text = booking.Guest.FirstName + " " + booking.Guest.LastName;
			lblPrevStartDate.Text = booking.StartDate.ToString("yyyy-MM-dd");
			lblPrevEndDate.Text = booking.EndDate.ToString("yyyy-MM-dd");
			lblPrevGuests.Text = booking.TotalBeds.ToString();
			lblPrevTotalBeds.Text= $"{booking.TotalBeds} ({prevExtraBeds} extra sängar)";
			lblPrevPrice.Text = booking.Invoice.Amount.ToString();
			lblPrevRoomDescription.Text = booking.Room.RoomType.Description;
			lblPrevRoomNumber.Text = booking.Room.Number.ToString();
		}

		private void SetAvailableRoomsView()
		{
			UpdateAvailableRoomsView();

			dgvAvailableRooms.Columns["RoomID"].Visible = false;
			dgvAvailableRooms.Columns["RoomTypeID"].Visible = false;
			dgvAvailableRooms.Columns["Beds"].Visible = false;

			dgvAvailableRooms.Columns["Description"].HeaderText = "Typ av rum";
			dgvAvailableRooms.Columns["CostPerNight"].HeaderText = "Kostnad per natt";
			dgvAvailableRooms.Columns["Number"].HeaderText = "Rumsnummer";
			dgvAvailableRooms.Columns["MaxExtraBeds"].HeaderText = "Tillgängliga extrasängar";

			for (int i = 0; i < dgvAvailableRooms.Columns.Count; i++)
			{
				dgvAvailableRooms.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}

			dgvAvailableRooms.Columns["Description"].FillWeight = 230;
		}

		private void SetGuestView()
		{
			dgvGuests.DataSource = _guestRepo.GetAllGuests();
			dgvGuests.Columns["Bookings"].Visible = false;
		}

		private void UpdateDateTimePickers()
		{
			if (_updateBooking != null)
			{
                dtpStartDate.MinDate = _updateBooking.StartDate;
            }
            else
			{
                dtpStartDate.MinDate = DateTime.Now.Date.AddDays(1);
			}

            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

		private void UpdateAvailableRoomsView()
		{
			var guests = 1;
			var availableRooms = new List<Room>();

			if (cmbGuests.Text != "") guests = Convert.ToInt32(cmbGuests.Text);

			if (_updateBooking != null)
			{
                availableRooms = _roomRepo.GetAvailableRooms(dtpStartDate.Value,
                dtpEndDate.Value,
                guests, _updateBooking);
            }
			else
			{
                availableRooms = _roomRepo.GetAvailableRooms(dtpStartDate.Value,
                dtpEndDate.Value,
                guests);
			}

			dgvAvailableRooms.DataSource = availableRooms.OrderBy(room => room.Number).Select(room => new
			{
				room.RoomID,
				room.RoomTypeID,
				room.RoomType.Description,
				room.RoomType.CostPerNight,
				room.Number,
				room.RoomType.MaxExtraBeds,
				room.RoomType.Beds
			}).ToList();
		}

		private void UpdateBookingInfo()
		{
			if (dgvAvailableRooms.CurrentRow != null &&
				dgvGuests.CurrentRow != null)
			{
				lblGuest.Text = dgvGuests.CurrentRow.Cells["FirstName"].Value +
				" " +
				dgvGuests.CurrentRow.Cells["LastName"].Value;

				lblStartDate.Text = dtpStartDate.Value.ToString("yyyy-MM-dd");
				lblEndDate.Text = dtpEndDate.Value.ToString("yyyy-MM-dd");
				lblPrice.Text = GetTotalPrice().ToString();
				lblRoomDescription.Text = dgvAvailableRooms.CurrentRow.Cells["Description"].Value.ToString();
				lblRoomNumber.Text = dgvAvailableRooms.CurrentRow.Cells["Number"].Value.ToString();
				lblGuests.Text = cmbGuests.Text;

				var totalBeds = int.Parse(dgvAvailableRooms.CurrentRow.Cells["Beds"].Value.ToString()) + 
					cmbExtraBeds.SelectedIndex;
				lblTotalBeds.Text = $"{totalBeds} ({cmbExtraBeds.Text} extra sängar)";
			}
		}

		private void UpdateExtraBeds()
		{
			var maxExtraBeds = (byte)dgvAvailableRooms.CurrentRow.Cells["MaxExtraBeds"].Value;

			cmbExtraBeds.Items.Clear();
			cmbExtraBeds.Text = string.Empty;

			if (maxExtraBeds == 0) cmbExtraBeds.Enabled = false;
			else cmbExtraBeds.Enabled = true;

			cmbExtraBeds.Items.Add(0.ToString());

			for (int i = 0; i < maxExtraBeds; i++)
			{
				var value = i + 1;
				cmbExtraBeds.Items.Add(value.ToString());
			}

			cmbExtraBeds.SelectedIndex = 0;
		}

		private void CreateBooking()
		{
			var booking = new Booking();
			var totalBeds = int.Parse(dgvAvailableRooms.CurrentRow.Cells["Beds"].Value.ToString()) +
					cmbExtraBeds.SelectedIndex;

			booking.StartDate = dtpStartDate.Value.Date;
			booking.EndDate = dtpEndDate.Value.Date;
			booking.GuestID = _selectedGuestID;
			booking.RoomID = _selectedRoomID;
			booking.InvoiceID = CreateInvoice();
			booking.IsCancelled = false;
			booking.TotalBeds = (byte)totalBeds;

			_bookingRepo.InsertBooking(booking);
		}

		private void UpdateBooking()
		{
            var totalBeds = int.Parse(dgvAvailableRooms.CurrentRow.Cells["Beds"].Value.ToString()) +
                    cmbExtraBeds.SelectedIndex;

            _updateBooking.StartDate = dtpStartDate.Value.Date;
            _updateBooking.EndDate = dtpEndDate.Value.Date;
            _updateBooking.GuestID = _selectedGuestID;
            _updateBooking.RoomID = _selectedRoomID;
            _updateBooking.IsCancelled = false;
            _updateBooking.TotalBeds = (byte)totalBeds;

			UpdateInvoice();
			_bookingRepo.UpdateBooking(_updateBooking);
        }

		private int CreateInvoice()
		{
			var invoice = new Invoice();

			invoice.InvoiceDate = DateTime.Now.Date;
			invoice.IsPaid = false;
			invoice.Amount = GetTotalPrice();

			return _invoiceRepo.InsertInvoice(invoice);
		}

		private int UpdateInvoice()
		{
			var invoice = new Invoice();

			invoice.InvoiceID = _updateBooking.InvoiceID;
			invoice.InvoiceDate = _updateBooking.Invoice.InvoiceDate;
            invoice.Amount = GetTotalPrice();
			invoice.IsPaid = _updateBooking.Invoice.IsPaid;

            if (invoice.Amount > _updateBooking.Invoice.Amount) invoice.IsPaid = false;

			return _invoiceRepo.UpdateInvoice(invoice);
        }

		private int GetTotalPrice()
		{
			var totalDays = (dtpEndDate.Value - dtpStartDate.Value).Days;
			var costPerNight = (int)dgvAvailableRooms.CurrentRow.Cells["CostPerNight"].Value;
			
			return totalDays * costPerNight;
		}

		private void dgvGuests_SelectionChanged(object sender, System.EventArgs e)
		{
			if (dgvGuests.CurrentRow == null) return;

			_selectedGuestID = (int)dgvGuests.CurrentRow.Cells["GuestID"].Value;
			UpdateBookingInfo();
		}

		private void dgvAvailableRooms_SelectionChanged(object sender, System.EventArgs e)
		{
			if (dgvAvailableRooms.CurrentRow == null) return;

			_selectedRoomID = (int)dgvAvailableRooms.CurrentRow.Cells["RoomID"].Value;
			UpdateBookingInfo();
			UpdateExtraBeds();
		}

		private void btnCreateBooking_Click(object sender, EventArgs e)
		{
			if (_updateBooking == null)
			{
                CreateBooking();
                var dateToPay = DateTime.Now;
                dateToPay = dateToPay.AddDays(MainForm.DaysToPay);

                MessageBox.Show($"Bokning inlagd i systemet, en faktura är skapad och betalas senast " +
                    $"{dateToPay.ToString("yyyy-MM-dd")}");
            }
			else
			{
				UpdateBooking();

				MessageBox.Show($"Bokningen och tillhörande faktura uppdaterades, sista betalningsdatum kvarstår " +
					$"{_updateBooking.Invoice.InvoiceDate.AddDays(MainForm.DaysToPay).ToString("yyyy-MM-dd")}");
			}

			Close();
		}

		private void dtpAny_ValueChanged(object sender, EventArgs e)
		{
			UpdateDateTimePickers();
			UpdateAvailableRoomsView();
			UpdateBookingInfo();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmbExtraBeds_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateBookingInfo();
		}

		private void cmbPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateBookingInfo();
			UpdateAvailableRoomsView();
		}

        private void BookingForm_Shown(object sender, EventArgs e)
        {
            dgvAvailableRooms.ClearSelection();
            dgvGuests.ClearSelection();
        }
    }
}
