using BookingSystem.Context;
using BookingSystem.Models;
using BookingSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Controllers
{
    public class BookingController : Controller
    {


        private readonly IBookingService _bookingService;
        private readonly IBookingHistoryService _bookingHistoryService;

        public BookingController(IBookingService bookingService, IBookingHistoryService bookingHistoryService)
        {
            _bookingService = bookingService;
            _bookingHistoryService = bookingHistoryService;
        }

        public ActionResult Index()
        {
            var bookings = _bookingService.GetAll();
            return View(bookings);
        }


        [HttpGet("Booking/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            var booking=_bookingService.GetById(id);
            if(booking==null)
            {
                return View("NotFound");
            }
            return View(booking);
        }

        
        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Booking booking)
        {
            if (!ModelState.IsValid)
            {
      
                return View(booking);
            }
            await _bookingService.Add(booking);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var booking =_bookingService.GetById(id);

            if (booking == null)
                return View("NotFound");

            return View(booking);
        }

        [HttpPost]
        public async Task<IActionResult> EditBooking(Booking newBooking)
        {
            if (!ModelState.IsValid)
                return View("Edit", newBooking);

            _bookingService.Update(newBooking);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var booking = _bookingService.GetById(id);
            return View(booking);
        }

      
        [HttpPost]
       
        public ActionResult Delete(int id, IFormCollection collection)
        {
           ;
            _bookingService.Delete(id);
            return RedirectToAction("Index");
        }



        public IActionResult FullyBooked()
        {
            return View();
        }


        [Authorize]
        public IActionResult History()
        {
            var bookings = _bookingHistoryService.GetPastBookings();
            return View(bookings);
        }






        public ActionResult Search(string name)
        {
            var bookings = _bookingService.SearchByName(name);
            return View(bookings);
        }



        //[HttpGet]
        //public IActionResult CheckServiceName(string service, DateTime appointmentDate)
        //{
        //    var exists = _context.Bookings
        //        .Any(b => b.Service == service
        //               && b.AppointmentDate.Date == appointmentDate.Date);

        //    if (exists)
        //    {
        //        return Json("That service is already booked for this date.");
        //    }

        //    return Json(true);
        //}


    }
}
