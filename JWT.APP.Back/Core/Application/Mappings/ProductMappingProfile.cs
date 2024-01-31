using AutoMapper;
using JWT.APP.Back.Core.Application.Dto;
using JWT.APP.Back.Core.Domain;
using System.Runtime.CompilerServices;

namespace JWT.APP.Back.Core.Application.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            this.CreateMap<Product,ProductListDto>().ReverseMap();
        }
    }
}
