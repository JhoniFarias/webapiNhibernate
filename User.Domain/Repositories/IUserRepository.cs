using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        IEnumerable<User> Get();
        void Update(User user);
        void Delete(User user);

    }
}
