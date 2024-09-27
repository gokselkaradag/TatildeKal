using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTO.AboutDTO;
using HotelProject.WebUI.DTO.AppUserDTO;
using HotelProject.WebUI.DTO.BookingDTO;
using HotelProject.WebUI.DTO.GuestDTO;
using HotelProject.WebUI.DTO.LoginDTO;
using HotelProject.WebUI.DTO.RegisterDTO;
using HotelProject.WebUI.DTO.ServiceDTO;
using HotelProject.WebUI.DTO.StaffDTO;
using HotelProject.WebUI.DTO.SubscribeDTO;
using HotelProject.WebUI.DTO.TestimonialDTO;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<AddServiceDTO, Service>().ReverseMap();

            CreateMap<AddRegisterDTO, AppUser>().ReverseMap();
            CreateMap<AddLoginDTO, AppUser>().ReverseMap();

            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();

            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDTO, Staff>().ReverseMap();

            CreateMap<AddSubscribeDTO, Subscribe>().ReverseMap();

            CreateMap<AddBookingDTO, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO, Booking>().ReverseMap();

            CreateMap<AddGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Guest>().ReverseMap();

            CreateMap<ResultAppUserDTO, AppUser>().ReverseMap();

        }
    }
}
