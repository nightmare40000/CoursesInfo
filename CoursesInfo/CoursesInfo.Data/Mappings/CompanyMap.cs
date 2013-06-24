using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class CompanyMap:ClassMap<Company>
    {
        public CompanyMap()
        {
            Table("Company");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name);
            Map(x => x.Phone);
            Map(x => x.Email);
            Map(x => x.Address);
            Map(x => x.About);
            Map(x => x.TimeWork);

            HasMany(x => x.Users)
                .Cascade.SaveUpdate();
            HasMany(x => x.Newses)
                .Cascade.SaveUpdate();
            HasMany(x => x.Courses)
                .Cascade.SaveUpdate();
        }
    }
}
