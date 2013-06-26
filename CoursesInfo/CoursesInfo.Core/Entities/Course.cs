using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class Course:EntitiesObject
    {
        public virtual int Id { set; get; }
        public virtual string Name { set; get; }
        public virtual int Cost { set; get; }
        public virtual int Time { set; get; }
        public virtual bool Actual { set; get; }
        public virtual int Duration { set; get; }
        public virtual string CoursesInfo { set; get; }
        public virtual DateTime DateStart { set; get; }
        public virtual IList<Tag> Tags { set; get; }
        public virtual Company Company { set; get; }
    }
}
