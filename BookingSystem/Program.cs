using BookingSystem.Context;
using BookingSystem.Middleware;
using BookingSystem.Models;
using BookingSystem.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("BookingSystem")
                )
            );

            builder.Services.AddScoped<IBookingService, BookingService>();
            builder.Services.AddScoped<IBookingHistoryService,BookingHistoryService>();
            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();


            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            
            app.UseStatusCodePagesWithRedirects("/Home/NotFound");

           
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();   
            app.UseAuthorization();


            app.UseMiddleware<MaxBookingsMiddleware>();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Register}/{id?}"
            );

            app.Run();
        }
    }
}