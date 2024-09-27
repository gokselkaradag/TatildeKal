using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserListWithWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appSserService;

        public AppUserListWithWorkLocationController(IAppUserService appSserService)
        {
            _appSserService = appSserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var values = _appSserService.TUsersListWithWorkLocations();

            DataContext context = new DataContext();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl,

            }).ToList();

            return Ok(values);
        }
    }
}
