using ApartmentManagementSystem.ApartmentManagementSystem.Core.Dtos;
using ApartmentManagementSystem.Entities;
using AutoMapper;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Core.MapperConfig
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserDto>();
            CreateMap<Admin, AdminLoginDto>();
        }
    }
}
