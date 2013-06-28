using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using CoursesInfo.Data;

namespace CoursesInfo.Business.Services
{
    public class CourseService:Service
    {
        private readonly IRepository<Course> _courseRepository
            = new NHibernateRepository<Course>();

        public IEnumerable<Course> GetTopCourses()
        {
            return _courseRepository.GetAll();
        }
    }
}
