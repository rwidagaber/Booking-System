namespace BookingSystem.Models
{
    public class BookingRepo
    {
        public static List<Booking> bookings = new()
{
    new Booking
    {
        BookingId = 1,
        CustomerName = "Ahmed Hassan",
        Phone = "01012345678",
        Service = "Haircut",
        AppointmentDate = DateTime.Now.AddDays(1)
    },
    new Booking
    {
        BookingId = 2,
        CustomerName = "Sara Ali",
        Phone = "01198765432",
        Service = "Massage",
        AppointmentDate = DateTime.Now.AddDays(2)
    },
    new Booking
    {
        BookingId = 3,
        CustomerName = "Mohamed Tarek",
        Phone = "01234567890",
        Service = "Dental Checkup",
        AppointmentDate = DateTime.Now.AddDays(3)
    },
    new Booking
    {
        BookingId = 4,
        CustomerName = "Nour Ibrahim",
        Phone = "01555555555",
        Service = "Facial",
        AppointmentDate = DateTime.Now.AddHours(6)
    },
    new Booking
    {
        BookingId = 5,
        CustomerName = "Omar Khaled",
        Phone = "01099998888",
        Service = "Gym Session",
        AppointmentDate = DateTime.Now.AddDays(7)
    }
};


        public static Booking GetBookingById(int id)
        {
            return bookings.FirstOrDefault(b => b.BookingId == id);
        }
    }
}
