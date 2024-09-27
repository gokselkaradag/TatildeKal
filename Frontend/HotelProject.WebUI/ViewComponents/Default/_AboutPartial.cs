using HotelProject.WebUI.DTO.AboutDTO;
using HotelProject.WebUI.DTO.ServiceDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5278/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDTO>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
