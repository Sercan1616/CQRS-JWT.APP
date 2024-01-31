using AutoMapper;
using JWT.APP.Back.Core.Application.Dto;
using JWT.APP.Back.Core.Domain;

namespace JWT.APP.Back.Core.Application.Mappings
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
