using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Repositories;

namespace User.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISession _session;

        public UserRepository(ISession session)
        {
            _session = session;
        }

        public void Create(Domain.User user)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Save(user);
                transaction.Commit();
            }
        }

        public void Delete(Domain.User user)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Delete(user);
                transaction.Commit();
            }
        }

        public IEnumerable<Domain.User> Get()
        {
            return _session.Query<Domain.User>().ToList();
        }

        public void Update(Domain.User user)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Update(user);
                transaction.Commit();
            }
        }
    }
}
