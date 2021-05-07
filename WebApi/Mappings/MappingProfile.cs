using AutoMapper;
using Domain.DTO;
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

            CreateMap<UserProfileDTO,UserProfile>()
                .ForMember(dest => dest.Image, o => o.MapFrom(src => src.Image))
                .ForMember(dest => dest.FacebookURL, o => o.MapFrom(src => src.FacebookURL))
                .ForMember(dest => dest.InstagramURL, o => o.MapFrom(src => src.InstagramURL))
                .ForMember(dest => dest.Gender, o => o.MapFrom(src => src.Gender))
                .ForMember(dest => dest.WorkDescription, o => o.MapFrom(src => src.WorkDescription))
                .ForMember(dest => dest.UserCategories, o => o.MapFrom(src => src.UserCategories))
            .ForAllOtherMembers(x=>x.Ignore());

            CreateMap<UserProfile,UserProfileDTO>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Image, o => o.MapFrom(src => src.Image))
                .ForMember(dest => dest.FacebookURL, o => o.MapFrom(src => src.FacebookURL))
                .ForMember(dest => dest.InstagramURL, o => o.MapFrom(src => src.InstagramURL))
                .ForMember(dest => dest.Gender, o => o.MapFrom(src => src.Gender))
                .ForMember(dest => dest.WorkDescription, o => o.MapFrom(src => src.WorkDescription))
                .ForMember(dest => dest.UserCategories, o => o.MapFrom(src => src.UserCategories))
            .ForAllOtherMembers(x=>x.Ignore());  

            CreateMap<UserCategory,UserCategoryDTO>()
                .ForMember(dest => dest.CategoryId, o => o.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForAllOtherMembers(x=>x.Ignore()); 

            CreateMap<UserCategoryDTO,UserCategory>()
                .ForMember(dest => dest.CategoryId, o => o.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForAllOtherMembers(x=>x.Ignore());

            CreateMap<PaintTypeDTO, PaintType>();
            CreateMap<PaintType, PaintTypeDTO>();
        }
    }
}