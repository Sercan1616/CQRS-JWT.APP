using JWT.APP.Back.Core.Application.Features.CQRS.Command;
using JWT.APP.Back.Core.Domain;
using JWT.APP.Back.Core.Interfaces;
using JWT.APP.Back.Infrastructure.Enums;
using MediatR;

namespace JWT.APP.Back.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IRepository<AppUser> repository;

        public RegisterUserCommandHandler(IRepository<AppUser> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new AppUser
            {
                UserName = request.Username,
                Password = request.Password,
                AppRoleId = (int)RoleType.Member
            });

            return Unit.Value;
        }
    }
}
