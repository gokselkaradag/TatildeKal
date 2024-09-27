using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService service)
        {
            _messageCategoryService = service;
        }

        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _messageCategoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory message)
        {
            _messageCategoryService.TInsert(message);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var values = _messageCategoryService.TGetByID(id);
            _messageCategoryService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateMessageCategory(MessageCategory message)
        {
            _messageCategoryService.TUpdate(message);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMessageCategory(int id)
        {
            var values = _messageCategoryService.TGetByID(id);
            return Ok(values);
        }
    }
}
