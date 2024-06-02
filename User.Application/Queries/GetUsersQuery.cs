using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Commands;

namespace User.Application.Queries
{
    public class GetUsersQuery : IRequest<CommandResult>
    {
    }
}
