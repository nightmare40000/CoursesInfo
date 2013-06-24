using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class TagMap: ClassMap<Tag>
    {
        public TagMap()
        {
            Table("Tag");
            Id(x => x.Id).GeneratedBy.Native();

            Map(x => x.Name);
        }
    }
}
