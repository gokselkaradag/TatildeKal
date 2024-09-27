using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTO.RegisterDTO
{
    public class AddRegisterDTO
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Şehir Alanı Gereklidir")]
        public string City { get; set; }
    }
}
