using JWT.APP.Back.Core.Application.Features.CQRS.Command;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IRepository<Category> repository;

        public DeleteCategoryCommandHandler(IRepository<Category> repository)
        {
            this.repository = repository;
        }
        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByIdAsync(request.Id);
            if (data != null)
            {
                await this.repository.DeleteAsync(data);
            }
            return Unit.Value;
        }
    }
}
