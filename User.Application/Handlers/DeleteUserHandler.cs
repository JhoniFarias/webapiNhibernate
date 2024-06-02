using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Commands;
using User.Domain.Repositories;

namespace User.Application.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, CommandResult>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<CommandResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.User()
            {
                Id = request.Id,
            };

            _userRepository.Delete(user);

            return Task.FromResult(new CommandResult() { Success = true });
        }
    }
}
