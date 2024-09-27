using HotelProject.WebUI.DTO.CategoryDTO;
using HotelProject.WebUI.DTO.ContactDTO;
using HotelProject.WebUI.DTO.RoomDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5278/api/MessageCategory");
            var jsondata = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsondata);
            List<SelectListItem> values2 = (from x in values
                                            select new SelectListItem
                                            {
                                                Text = x.MessageCategoryName,
                                                Value = x.MessageCategoryID.ToString()
                                            }).ToList();
            ViewBag.v = values2;

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5278/api/AgeCategory");
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<List<ResultAgeCategoryDTO>>(jsondata2);
            List<SelectListItem> values3 = (from y in values1
                                            select new SelectListItem
                                            {
                                                Text = y.AgeCategoryNumber,
                                                Value = y.AgeCategoryID.ToString()
                                            }).ToList();
            ViewBag.a = values3;

            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(AddContactDTO addContactDTO)
        {
            addContactDTO.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addContactDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5278/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
