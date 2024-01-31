using AutoMapper;
using JWT.APP.Back.Core.Application.Dto;
using JWT.APP.Back.Core.Application.Features.CQRS.Queries;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
    {
        private readonly IRepository<Product> repository;

        private readonly IMapper mapper;

        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return mapper.Map<ProductListDto>(data);
        }
    }
}
