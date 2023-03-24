using HotelBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking.Repository
{
    public class GuestRepo
    {
        private HOTELBOOKINGEntities _dbConnection;

        public GuestRepo()
        {
            _dbConnection = new HOTELBOOKINGEntities();
        }

        public Guest GetGuest(int guestID)
        {
            return _dbConnection.Guests.Find(guestID);
        }

        public List<Guest> GetAllGuests()
        {
            return _dbConnection.Guests.ToList();
        }

        public bool GuestHasBookings(int guestID)
        {
            return _dbConnection.Bookings.Any(booking => booking.GuestID == guestID);
        }

        public int InsertGuest(Guest guest)
        {
            _dbConnection.Guests.Add(guest);
            _dbConnection.SaveChanges();

            return guest.GuestID;
        }

        public int UpdateGuest(Guest guest)
        {
            var originalGuest = GetGuest(guest.GuestID);

            _dbConnection.Entry(originalGuest).CurrentValues.SetValues(guest);
            return _dbConnection.SaveChanges();
        }

        public int DeleteGuest(int guestID)
        {
            var guest = GetGuest(guestID);

            _dbConnection.Guests.Remove(guest);
            return _dbConnection.SaveChanges();
        }
    }
}
