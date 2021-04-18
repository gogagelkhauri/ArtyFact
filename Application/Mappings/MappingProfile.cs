using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDTO,Category>();
            CreateMap<Category,CategoryDTO>();
        }
    }
}