using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Commands;
using User.Application.Queries;
using User.Domain.Repositories;
using User.Infrastructure.Repositories;

namespace User.Application.Handlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, CommandResult>
    {
        private readonly IUserRepository _userRepository;

        public GetUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository; 
        }

        public Task<CommandResult> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
