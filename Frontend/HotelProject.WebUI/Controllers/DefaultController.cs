using HotelProject.WebUI.DTO.RoomDTO;
using HotelProject.WebUI.DTO.ServiceDTO;
using HotelProject.WebUI.DTO.SubscribeDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(AddSubscribeDTO addSubscribeDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addSubscribeDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5278/api/Subscribe", stringContent);
            return RedirectToAction("Index" , "Default");

        }
    }
}
