using BookingSystem.Models;

namespace BookingSystem.Services
{
    public interface IBookingHistoryService
    {
        IEnumerable<Booking> GetPastBookings();
    }
}
