using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class CommentMap:ClassMap<Comment>
    {
        public CommentMap()
        {
            Table("Comment");

            Id(x => x.Id).GeneratedBy.Native();

            Map(x => x.Text);
            Map(x => x.ContentGroup);
        }
    }
}
