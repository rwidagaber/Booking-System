using Azure;
using BookingSystem.Context;
using BookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Services
{
    public class BookingService : IBookingService
    {
       private readonly AppDbContext _context;
        public BookingService(AppDbContext context) {
            _context = context;
        }
        public async Task Add(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var booking = _context.Bookings.FirstOrDefault(b => b.BookingId == id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetById(int id)
        {
            var booking= _context.Bookings.FirstOrDefault(b=>b.BookingId==id);
            return booking;
        }

        

        public void Update(Booking booking)
        {
            var oldBooking = _context.Bookings
                .FirstOrDefault(b => b.BookingId == booking.BookingId);

            if (oldBooking != null)
            {
                oldBooking.CustomerName = booking.CustomerName;
                oldBooking.Service = booking.Service;
                oldBooking.Phone = booking.Phone;
                oldBooking.AppointmentDate = booking.AppointmentDate;

                _context.SaveChanges(); 
            }
        }



        public IEnumerable<Booking> GetUpcomingBookings()
        {
            return _context.Bookings.Where(b => b.AppointmentDate > DateTime.Today).ToList();
        }

        public IEnumerable<Booking> SearchByName(string name)
        {
            return _context.Bookings
           .Where(b => b.CustomerName.Contains(name))
           .ToList();
        }


    }
}
