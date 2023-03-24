using HotelBooking.Models;
using HotelBooking.Views;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking.Repository
{
    public class BookingRepo
    {
        private HOTELBOOKINGEntities _dbConnection;

        public BookingRepo()
        {
            _dbConnection= new HOTELBOOKINGEntities();
        }

        public List<Booking> GetAllBookings()
        {
            return _dbConnection.Bookings
                .Include("Invoice")
                .Include("Guest")
                .Include("Room")
                .ToList();
        }

        public Booking GetBooking(int bookingID)
        {
            return _dbConnection.Bookings.Find(bookingID);
        }

        public int InsertBooking(Booking booking)
        {
            _dbConnection.Bookings.Add(booking);
            _dbConnection.SaveChanges();

            return booking.BookingID;
        }

        public int UpdateBooking(Booking booking)
        {
            var originalBooking = GetBooking(booking.BookingID);

            _dbConnection.Entry(originalBooking).CurrentValues.SetValues(booking);
            return _dbConnection.SaveChanges();
        }

        public int DeleteBooking(int bookingID)
        {
            var booking = GetBooking(bookingID);
            var invoiceRepo = new InvoiceRepo();
            var invoiceID = booking.InvoiceID;

            _dbConnection.Bookings.Remove(booking);
            var stateEntries = _dbConnection.SaveChanges();

            invoiceRepo.DeleteInvoice(invoiceID);

            return stateEntries;
        }
    }
}
