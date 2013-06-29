using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class Comment:EntitiesObject
    {
        public virtual int Id { get; set; }
        public virtual int ContentGroup { get; set; }
        public virtual string Text { get; set; }        
    }
}
