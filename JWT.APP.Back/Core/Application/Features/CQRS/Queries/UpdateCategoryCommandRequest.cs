using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Queries
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
        public UpdateCategoryCommandRequest(int id)
        {
            Id = id;
        }

    }
}
