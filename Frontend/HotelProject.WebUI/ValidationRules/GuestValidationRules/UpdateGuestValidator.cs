using FluentValidation;
using HotelProject.WebUI.DTO.GuestDTO;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDTO>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez");
        }
    }
}
