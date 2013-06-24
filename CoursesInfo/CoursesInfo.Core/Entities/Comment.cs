using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class Comment
    {
        public virtual int Id { set; get; }
        public virtual string Text { set; get; }
        public virtual int Group { set; get; }
    }
}
