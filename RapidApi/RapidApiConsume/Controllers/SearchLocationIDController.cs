using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                List<ApiLocationSearchViewModel> apiLocationSearchViewModels = new List<ApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
    {
        { "x-rapidapi-key", "423e0b03e1mshf1e648621fe968ap14c847jsndbb209c3460f" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    apiLocationSearchViewModels = JsonConvert.DeserializeObject<List<ApiLocationSearchViewModel>>(body);
                    return View(apiLocationSearchViewModels.Take(1).ToList());
                }
            }
            else
            {
                List<ApiLocationSearchViewModel> apiLocationSearchViewModels = new List<ApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-gb"),
                    Headers =
    {
        { "x-rapidapi-key", "423e0b03e1mshf1e648621fe968ap14c847jsndbb209c3460f" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    apiLocationSearchViewModels = JsonConvert.DeserializeObject<List<ApiLocationSearchViewModel>>(body);
                    return View(apiLocationSearchViewModels.Take(1).ToList());
                }
            }
        }
    }
}
