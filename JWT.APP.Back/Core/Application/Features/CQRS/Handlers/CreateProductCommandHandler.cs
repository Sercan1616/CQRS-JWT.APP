using JWT.APP.Back.Core.Application.Features.CQRS.Command;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IRepository<Product> repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
               await this.repository.CreateAsync(new Product
               {
                   Name = request.Name,
                   Stock = request.Stock,
                   Price = request.Price,
                   CategoryId = request.CategoryId,
               });

            return Unit.Value;
        }
    }
}
