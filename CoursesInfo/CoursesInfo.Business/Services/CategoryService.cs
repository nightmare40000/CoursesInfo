using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using CoursesInfo.Data;

namespace CoursesInfo.Business.Services
{
    class CategoryService: Service
    {
        private readonly IRepository<Category> _categoryRepository
            =new NHibernateRepository<Category>();

        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }
    }
}
