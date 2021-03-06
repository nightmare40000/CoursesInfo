﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class News: EntitiesObject
    {
        public virtual int Id { set; get; }
        public virtual string Title { set; get; }
        public virtual string Text { set; get; }
        public virtual IList<Tag> Tags { set; get; }
        public virtual IList<Comment> Comments { set; get; }
        public virtual Company Company { set; get; }
    }
}
