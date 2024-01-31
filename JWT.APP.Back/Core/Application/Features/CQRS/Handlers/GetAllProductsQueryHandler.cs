using AutoMapper;
using JWT.APP.Back.Core.Application.Dto;
using JWT.APP.Back.Core.Application.Features.CQRS.Queries;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> repository;
        private readonly IMapper mapper;
        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<List<ProductListDto>>(data);
        }
    }
}
