using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTO.RegisterDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AddRegisterDTO addRegisterDTO)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = addRegisterDTO.Name,
                Surname = addRegisterDTO.Surname,
                Email = addRegisterDTO.Email,
                UserName = addRegisterDTO.Username,
                City = addRegisterDTO.City,
                WorkLocationID = 1
            };
            var result = await _userManager.CreateAsync(appUser, addRegisterDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
