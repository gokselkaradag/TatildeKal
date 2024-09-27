using HotelProject.WebUI.DTO.AppUserDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUserListWithWorkLocationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserListWithWorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5278/api/AppUserListWithWorkLocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserListWithWorkLocationDTO>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
