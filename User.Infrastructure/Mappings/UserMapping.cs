using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Infrastructure.Mappings
{
    public class UserMapping : ClassMap<Domain.User>
    {
        public UserMapping()
        {
            Id(x => x.Id, "ID");
            Map(x => x.Name, "NAME");
            Map(x => x.Email, "EMAIL");
            Map(x => x.Age, "AGE");
            Table("CONTACT");
        }
    }
}
