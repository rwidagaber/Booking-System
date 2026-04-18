using BookingSystem.Models;

namespace BookingSystem.Middleware
{
    public class MaxBookingsMiddleware
    {
        private readonly RequestDelegate _next;

        public MaxBookingsMiddleware(RequestDelegate next)
        {
            //new()"""""""""""
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/Booking/Create"))
            {
                
                int todayCount = BookingRepo.bookings
                    .Count(b => b.AppointmentDate.Date == DateTime.Today);

                if (todayCount >= 2)
                {
                    context.Response.Redirect("/Booking/FullyBooked");
                    return;
                }
            }

            await _next(context);
        }
    }



}