using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeCategoryController : ControllerBase
    {
        private readonly IAgeCategoryService _ageCategoryService;

        public AgeCategoryController(IAgeCategoryService ageCategoryService)
        {
            _ageCategoryService = ageCategoryService;
        }

        [HttpGet]
        public IActionResult AgeCategoryList()
        {
            var values = _ageCategoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAgeCategory(AgeCategory category)
        {
            _ageCategoryService.TInsert(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAgeCategory(int id)
        {
            var values = _ageCategoryService.TGetByID(id);
            _ageCategoryService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAgeCategory(AgeCategory category)
        {
            _ageCategoryService.TUpdate(category);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAgeCategory(int id)
        {
            var values = _ageCategoryService.TGetByID(id);
            return Ok(values);
        }
    }
}
