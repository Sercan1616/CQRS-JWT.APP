using JWT.APP.Back.Core.Application.Dto;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Command
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
