using HotelProject.WebUI.DTO.BookingDTO;
using HotelProject.WebUI.DTO.SubscribeDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(AddBookingDTO addBookingDTO)
        {
            addBookingDTO.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addBookingDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5278/api/Booking", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
