using AutoMapper;
using JWT.APP.Back.Core.Application.Features.CQRS.Command;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updateProduct = await this.repository.GetByIdAsync(request.Id);
            if (updateProduct != null)
            {
                updateProduct.Name = request.Name;
                updateProduct.Stock = request.Stock;
                updateProduct.Price = request.Price;
                updateProduct.CategoryId = request.CategoryId;
                await this.repository.UpdateAsync(updateProduct);
            }
            return Unit.Value;
        }
    }
}
