using AutoMapper;
using HotelProject.DtoLayer.DTO.RoomDTO;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDTO, Room>();
            CreateMap<Room, RoomAddDTO>();

            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
        }
    }
}
