using BookingSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;
namespace BookingSystem.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }

       
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("Server = .;Database=BookingSystem;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var seedDate = new DateTime(2026, 4, 6, 0, 0, 0, DateTimeKind.Utc);
            modelBuilder.Entity<Booking>().HasData(
                 new Booking
                 {
                     BookingId = 1,
                     CustomerName = "Ahmed Hassan",
                     Phone = "01012345678",
                     Service = "Haircut",
                     AppointmentDate = seedDate
                 },
    new Booking
    {
        BookingId = 2,
        CustomerName = "Sara Ali",
        Phone = "01198765432",
        Service = "Massage",
        AppointmentDate = seedDate
    },
    new Booking
    {
        BookingId = 3,
        CustomerName = "Mohamed Tarek",
        Phone = "01234567890",
        Service = "Dental Checkup",
        AppointmentDate = seedDate
    },
    new Booking
    {
        BookingId = 4,
        CustomerName = "Nour Ibrahim",
        Phone = "01555555555",
        Service = "Facial",
        AppointmentDate = seedDate
    },
    new Booking
    {
        BookingId = 5,
        CustomerName = "Omar Khaled",
        Phone = "01099998888",
        Service = "Gym Session",
        AppointmentDate = seedDate
    }
              );



        }

        
    }
}
