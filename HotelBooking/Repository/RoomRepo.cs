using HotelBooking.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking.Repository
{
    public class RoomRepo
    {
        private HOTELBOOKINGEntities _dbConnection;

        public RoomRepo()
        {
            _dbConnection= new HOTELBOOKINGEntities();
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int guests)
        {
            var rooms = _dbConnection.Rooms
                .Include("RoomType")
                .Where(room => !room.Bookings
                .Any(booking => (booking.StartDate <= startDate && booking.EndDate >= startDate) ||
                (booking.StartDate <= endDate && booking.EndDate >= endDate) ||
                (booking.StartDate >= startDate && booking.EndDate <= endDate)))
                .ToList();

            rooms = rooms.Where(room => room.RoomType.Beds + room.RoomType.MaxExtraBeds >= guests).ToList();

            return rooms;
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int guests, Booking updateBooking)
        {
            var rooms = _dbConnection.Rooms
                .Include("RoomType")
                .Where(room => !room.Bookings
                .Where(booking => booking.BookingID != updateBooking.BookingID)
                .Any(booking => (booking.StartDate <= startDate && booking.EndDate >= startDate) ||
                (booking.StartDate <= endDate && booking.EndDate >= endDate) ||
                (booking.StartDate >= startDate && booking.EndDate <= endDate)))
                .ToList();

            rooms = rooms.Where(room => room.RoomType.Beds + room.RoomType.MaxExtraBeds >= guests).ToList();

            return rooms;
        }
    }
}
