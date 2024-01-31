using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Command
{
    public class CreateCategoryCommandRequest : IRequest
    {
        public string? Definition { get; set; }
    }
}
