using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTO.LoginDTO
{
    public class AddLoginDTO
    {
        [Required(ErrorMessage ="Kullanıcı Adınızı Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
