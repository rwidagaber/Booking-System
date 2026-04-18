using BookingSystem.Models;

namespace BookingSystem.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetAll();
        Booking GetById(int id);
         Task Add(Booking booking);
        void Update(Booking booking);
        void Delete(int id);
        IEnumerable<Booking> SearchByName(string name);
        IEnumerable<Booking> GetUpcomingBookings();


    }
}
