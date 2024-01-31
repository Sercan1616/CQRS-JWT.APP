using JWT.APP.Back.Core.Application.Dto;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
    {

    }
}
