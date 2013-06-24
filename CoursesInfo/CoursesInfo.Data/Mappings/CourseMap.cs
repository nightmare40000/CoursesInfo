using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class CourseMap:ClassMap<Course>
    {
        public CourseMap()
        {
            Table("Course");
            Id(x => x.Id).GeneratedBy.Native();

            Map(x => x.Name);
            Map(x => x.CoursesInfo);
            Map(x => x.Cost);
            Map(x => x.Actual);
            Map(x => x.Duration);
            Map(x => x.Time);
            Map(x => x.DateStart);

            HasManyToMany(x => x.Tags)
                .Table("CourseTag")
                .ParentKeyColumn("IdCourse")
                .ChildKeyColumn("IdTag")
                .Cascade.SaveUpdate();
            References(x => x.Company);
        }
    }
}
