using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using Domain.Entities.User;
using WebApi.Resources;

namespace MyMusic.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserSignUpResource, ApplicationUser>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
            CreateMap<CategoryDTO,Category>();
            CreateMap<Category,CategoryDTO>();
        }
    }
}