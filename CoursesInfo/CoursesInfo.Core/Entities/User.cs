using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class User
    {
        public virtual int Id { set; get; }
        public virtual string Name { set; get; }
        public virtual string Email { set; get; }
        public virtual string Login { set; get; }
        public virtual string Password { set; get; }
        public virtual int PermissionGroup { set; get; }
        public virtual IList<Comment> Comments { set; get; }
        public virtual Company Company { set; get; }
    }
}
