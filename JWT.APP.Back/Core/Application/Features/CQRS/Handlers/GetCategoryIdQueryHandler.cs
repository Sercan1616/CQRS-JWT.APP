using AutoMapper;
using JWT.APP.Back.Core.Application.Dto;
using JWT.APP.Back.Core.Application.Features.CQRS.Queries;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryIdQueryHandler : IRequestHandler<GetCategoryIdQueryRequest, CategoryListDto?>
    {
        private readonly IRepository<Category> repository;
        private readonly IMapper mapper;

        public GetCategoryIdQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<CategoryListDto>(data);
        }
    }
}
