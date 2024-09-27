using HotelProject.WebUI.DTO.ContactDTO;
using HotelProject.WebUI.DTO.SendMessageDTO;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5278/api/Contact");

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5278/api/Contact/GetContactCount");

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client2.GetAsync("http://localhost:5278/api/SendMessage/GetSendCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDTO>>(jsondata);

                var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.contactCount = jsondata2;

                var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.sendCount = jsondata3;

                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5278/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDTO>>(jsondata);
                return View(values);
            }
            return View();
        }

        public PartialViewResult AdminContactPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminContactCategoryPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminContacAgeCategoryPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(AddSendMessageDTO model)
        {
            model.SenderMail = "admin@gmail.com";
            model.SenderName = "admin";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5278/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }

        public async Task<IActionResult> MessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5278/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDTO>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5278/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultContactDTO>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
