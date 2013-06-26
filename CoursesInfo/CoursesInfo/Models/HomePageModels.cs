using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoursesInfo.Core.Entities;

namespace CoursesInfo.Models
{
    public class NewsModel
    {
        public virtual int Id { set; get; }
        public virtual string Title { set; get; }
        public virtual string Text { set; get; }
        public virtual IList<Tag> Tags { set; get; }
        public virtual Company Company { set; get; }
    }
}