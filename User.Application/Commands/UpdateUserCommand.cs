using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Application.Commands
{
    public class UpdateUserCommand : IRequest<CommandResult>
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Age { get; set; }
    }
}
