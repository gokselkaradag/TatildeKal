using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.DTO.ContactDTO
{
    public class AddContactDTO
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
        public int AgeCategoryID { get; set; }
    }
}
