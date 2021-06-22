using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;

namespace Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

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
                .ForMember(dest => dest.Category, o => o.MapFrom(src => src.Category))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForAllOtherMembers(x=>x.Ignore()); 

            CreateMap<UserCategoryDTO,UserCategory>()
                .ForMember(dest => dest.CategoryId, o => o.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForAllOtherMembers(x=>x.Ignore());

            //CreateMap<PaintTypeDTO, PaintType>();
            //CreateMap<PaintType, PaintTypeDTO>();

            //CreateMap<ProductDetail, ProductDetailDTO>()
            //    .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.ProductId, o => o.MapFrom(src => src.ProductId))
            //    .ForMember(dest => dest.Size, o => o.MapFrom(src => src.Size))
            //    .ForMember(dest => dest.PaintType, o => o.MapFrom(src => src.PaintType))
            //    .ForMember(dest => dest.PaintTypeId, o => o.MapFrom(src => src.PaintTypeId))
            //    .ForAllOtherMembers(x => x.Ignore());

            //CreateMap<ProductDetailDTO, ProductDetail>()
            //    .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
            //    //.ForMember(dest => dest.ProductId, o => o.MapFrom(src => src.ProductId))
            //    .ForMember(dest => dest.Size, o => o.MapFrom(src => src.Size))
            //    .ForMember(dest => dest.PaintType, o => o.MapFrom(src => src.PaintType))
            //    .ForMember(dest => dest.PaintTypeId, o => o.MapFrom(src => src.PaintTypeId))
            //    .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name))
                .ForMember(dest => dest.InStock, o => o.MapFrom(src => src.InStock))
                .ForMember(dest => dest.Description, o => o.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageURL, o => o.MapFrom(src => src.ImageURL))
                .ForMember(dest => dest.Price, o => o.MapFrom(src => src.Price))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Category, o => o.MapFrom(src => src.Category))
                .ForMember(dest => dest.CategoryId, o => o.MapFrom(src => src.CategoryId))
                //.ForMember(dest => dest.ProductDetail, o => o.MapFrom(src => src.ProductDetail))
                .ForAllOtherMembers(x => x.Ignore());

                CreateMap<ProductDTO, Product>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name))
                .ForMember(dest => dest.InStock, o => o.MapFrom(src => src.InStock))
                .ForMember(dest => dest.Description, o => o.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageURL, o => o.MapFrom(src => src.ImageURL))
                .ForMember(dest => dest.Price, o => o.MapFrom(src => src.Price))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Category, o => o.MapFrom(src => src.Category))
                .ForMember(dest => dest.CategoryId, o => o.MapFrom(src => src.CategoryId))
                //.ForMember(dest => dest.ProductDetail, o => o.MapFrom(src => src.ProductDetail))
                .ForAllOtherMembers(x => x.Ignore());

                CreateMap<Post, PostDTO>()
                    .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Title, o => o.MapFrom(src => src.Title))
                    .ForMember(dest => dest.Date, o => o.MapFrom(src => src.Date))
                    .ForMember(dest => dest.Description, o => o.MapFrom(src => src.Description))
                    .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.User, o => o.MapFrom(src => src.User))
                    .ForMember(dest => dest.ImageURL, o => o.MapFrom(src => src.ImageURL));

                CreateMap<PostDTO,Post>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, o => o.MapFrom(src => src.Title))
                .ForMember(dest => dest.Date, o => o.MapFrom(src => src.Date))
                .ForMember(dest => dest.Description, o => o.MapFrom(src => src.Description))
                .ForMember(dest => dest.UserId, o => o.MapFrom(src => src.UserId))
                .ForMember(dest => dest.User, o => o.MapFrom(src => src.User))
                .ForMember(dest => dest.ImageURL, o => o.MapFrom(src => src.ImageURL));



        }
    }
}