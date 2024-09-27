using HotelProject.WebUI.DTO.BookingDTO;
using HotelProject.WebUI.DTO.StaffDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast6Bookings : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardLast6Bookings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5278/api/Booking/Last6Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast6BookingDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
