using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Command
{
    public class RegisterUserCommandRequest : IRequest
    {
        public string? Username{ get; set; }
        public string? Password{ get; set; }
    }
}
