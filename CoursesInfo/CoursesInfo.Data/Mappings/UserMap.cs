using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using FluentNHibernate.Mapping;

namespace CoursesInfo.Data.Mappings
{
    public class UserMap:ClassMap<User>
    {
        public UserMap()
        {
            Table("User");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name);
            Map(x => x.Email);
            Map(x => x.Login);
            Map(x => x.Password);
            Map(x => x.PermissionGroup);

            HasManyToMany(x => x.Comments)
                .Table("UserComments")
                .ParentKeyColumn("IdUser")
                .ChildKeyColumn("IdComment")
                .Cascade.SaveUpdate();
            References(x => x.Company);
        }
    }
}
