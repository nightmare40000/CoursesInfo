using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoursesInfo.Core.Entities;

namespace CoursesInfo.Models
{
    public class MainPageModel
    {
        public virtual IEnumerable<News> News { get; set; }
        public virtual IEnumerable<Category> Categories { set; get; }
        public virtual IEnumerable<Course> Courses { set; get; }
    }


    public class CategoriesModel : MainPageModel
    {
        public virtual Category CurentCategory { get; set; }
    }

    public class NewsModel : MainPageModel
    {
        public virtual News CurrentNews { get; set; }
    }

}