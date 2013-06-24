using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Category");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name);

            HasManyToMany(x => x.Courses)
                .Table("CoursesInCategory")
                .ParentKeyColumn("IdCategory")
                .ChildKeyColumn("IdCourses")
                .Cascade.SaveUpdate();
        }
    }
}
