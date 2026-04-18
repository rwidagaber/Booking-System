using BookingSystem.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Required(ErrorMessage = "Customer name is required")]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Service name is required")]
        //[Remote("CheckServiceName", "Booking", AdditionalFields = "AppointmentDate")]
        public string Service { get; set; }

        [Required(ErrorMessage = "Appointment Date is required")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Appointment date must be in the future")]

        //[FutureDate(ErrorMessage = "date must be in the future")]
        public DateTime AppointmentDate { get; set; }
    }
}
