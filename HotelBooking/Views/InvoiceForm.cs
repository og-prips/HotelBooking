using System;
using System.Windows.Forms;
using HotelBooking.Models;
using HotelBooking.Repository;

namespace HotelBooking.Views
{
    public partial class InvoiceForm : Form
    {
        private Invoice _invoice;

        public InvoiceForm(Invoice invoice, Booking booking)
        {
            _invoice = invoice;
            
            InitializeComponent();

            chkIsPaid.Checked = invoice.IsPaid;
            lblInvoiceDate.Text = _invoice.InvoiceDate.ToString("yyyy-MM-dd");
            lblLastPayDate.Text = _invoice.InvoiceDate.AddDays(MainForm.DaysToPay).ToString("yyyy-MM-dd");
            lblGuest.Text = booking.Guest.FirstName + " " + booking.Guest.LastName;
            lblPrice.Text = _invoice.Amount.ToString("n");
            lblStatus.Text = _invoice.IsPaid ? "Betalad" : "Ej betalad";

            txtDescription.Text = $"Fakturan gäller för bokningen i rum {booking.Room.Number} mellan datumen\r" +
                $"{booking.StartDate.ToString("yyyy-MM-dd")} och {booking.EndDate.ToString("yyyy-MM-dd")}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var invoiceRepo = new InvoiceRepo();

            _invoice.IsPaid = chkIsPaid.Checked;
            invoiceRepo.UpdateInvoice(_invoice);

            if (chkIsPaid.Checked )
            {
                MessageBox.Show("Fakturan sparades som betald");
            }
            else
            {
                MessageBox.Show("Fakturan sparades som ej betald");
            }

            Close();
        }
    }
}
