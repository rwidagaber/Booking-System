using BookingSystem.Context;
using BookingSystem.Models;

namespace BookingSystem.Services
{
    public class BookingHistoryService : IBookingHistoryService
    {
        private readonly AppDbContext _context;

        public BookingHistoryService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Booking> GetPastBookings()
        {
            return _context.Bookings.Where(b=>b.AppointmentDate<DateTime.Today).ToList();
        }
    }
}
