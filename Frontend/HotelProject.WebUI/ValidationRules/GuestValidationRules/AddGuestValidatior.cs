using FluentValidation;
using HotelProject.WebUI.DTO.GuestDTO;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class AddGuestValidatior : AbstractValidator<AddGuestDTO>
    {
        public AddGuestValidatior()
        {
            RuleFor(x =>  x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x =>  x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x =>  x.City).NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez");
        }
    }
}
