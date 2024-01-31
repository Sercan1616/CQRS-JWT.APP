using JWT.APP.Back.Core.Application.Dto;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryIdQueryRequest : IRequest<CategoryListDto?>
    {
        public int Id { get; set; }
        public GetCategoryIdQueryRequest(int id)
        {
            Id = id;
        }

        

    }
}
