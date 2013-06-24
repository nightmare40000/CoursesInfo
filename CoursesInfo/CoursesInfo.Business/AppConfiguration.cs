using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Data;

namespace CoursesInfo.Business
{
    public class AppConfiguration
    {
        public static void Configure()
        {
            DataBaseConfig.Config();
        }
    }
}
