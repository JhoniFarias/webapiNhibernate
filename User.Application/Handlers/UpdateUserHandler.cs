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
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, CommandResult>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<CommandResult> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.User()
            {
                Age = request.Age,
                Email = request.Email,
                Name = request.Name
            };

            _userRepository.Update(user);

            return Task.FromResult(new CommandResult() { Success = true });
        }
    }
}
