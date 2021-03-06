﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesInfo.Core.Entities
{
    public class Category:EntitiesObject
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Course> Courses { set; get; }
    }
}
