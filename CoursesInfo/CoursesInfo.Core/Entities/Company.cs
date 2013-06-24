using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class Company
    {
        public virtual int Id { set; get; }
        public virtual string Name { set; get; }
        public virtual string Address { set; get; }
        public virtual string TimeWork { set; get; }
        public virtual string About { set; get; }
        public virtual string Phone { set; get; }
        public virtual string Email { set; get; }
        public virtual IList<Course> Courses { set; get; }
        public virtual IList<User> Users { set; get; }
        public virtual IList<News> Newses { set; get; }
    }
}
