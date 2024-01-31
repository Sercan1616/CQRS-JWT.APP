using JWT.APP.Back.Core.Application.Features.CQRS.Command;
using JWT.APP.Back.Infrastructure.Tools;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.APP.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register (RegisterUserCommandRequest request)
        {
            await this._mediator.Send(request);
            return Created("", request);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(CheckUserQueryRequest request)
        {
            var dto = await this._mediator.Send(request);
            return dto.IsExist ? Created("", JwtTokenGenerator.GenerateToken(dto)) : BadRequest("Kullanıcı adı veya şifre hatalı");
        }
    }
}
