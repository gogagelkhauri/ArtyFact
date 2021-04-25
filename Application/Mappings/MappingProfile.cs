using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;

namespace Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDTO,Category>();
            CreateMap<Category,CategoryDTO>();

            CreateMap<UserProfileDTO,UserProfile>()
            .ForAllOtherMembers(x=>x.Ignore());
                //.ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                // .ForMember(dest => dest.Image, o => o.MapFrom(src => src.Image))
                // .ForMember(dest => dest.FacebookURL, o => o.MapFrom(src => src.FacebookURL))
                // .ForMember(dest => dest.Gender, o => o.MapFrom(src => src.Gender))
                // .ForMember(dest => dest.WorkDescription, o => o.MapFrom(src => src.WorkDescription));
                //.ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId));
            CreateMap<UserProfile,UserProfileDTO>()
            .ForAllOtherMembers(x=>x.Ignore());         
                //.ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                // .ForMember(dest => dest.Image, o => o.MapFrom(src => src.Image))
                // .ForMember(dest => dest.FacebookURL, o => o.MapFrom(src => src.FacebookURL))
                // .ForMember(dest => dest.Gender, o => o.MapFrom(src => src.Gender))
                // .ForMember(dest => dest.WorkDescription, o => o.MapFrom(src => src.WorkDescription));
                // //.ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId));

            //.IgnoreAllNonExisting();
        }
    }
}