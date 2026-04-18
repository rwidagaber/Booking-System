namespace BookingSystem.Middleware
{
    public class PreventService
    {
        private readonly RequestDelegate _next;

        public PreventService(RequestDelegate next)
        {
            //new()"""""""""""
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/Booking/Create"))
            {
                context.Request.Query.TryGetValue("Service", out var service);

                if (service == "Dental Checkup")
                {
                    context.Response.Redirect("/Booking/FullyBooked");
                    return;
                }
            }

            await _next(context);
        }
    }
}
