using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class NewsMap: ClassMap<News>
    {
        public NewsMap()
        {
            Table("News");
            Id(x => x.Id).GeneratedBy.Native();

            Map(x => x.Title);
            Map(x => x.Text);

            HasManyToMany(x => x.Tags)
                .Table("NewsTag")
                .ParentKeyColumn("IdNews")
                .ChildKeyColumn("IdTag")
                .Cascade.SaveUpdate();
            References(x => x.Company);
        }
    }
}
