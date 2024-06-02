using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class User
    {
        public User() { }

        public User(string name, string email, string age)
        {
            Name = name;
            Email = email;
            Age = age;
        }


        public virtual int Id { get;  set; }

        public virtual string Name { get; set; }

        public virtual string Email { get;  set; } = string.Empty;

        public virtual string Age { get;  set; }



    }
}
