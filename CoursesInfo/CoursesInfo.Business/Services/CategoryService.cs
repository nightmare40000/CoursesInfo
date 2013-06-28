using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using CoursesInfo.Data;

namespace CoursesInfo.Business.Services
{
    public class CategoryService: Service
    {
        private readonly IRepository<Category> _categoryRepository
            =new NHibernateRepository<Category>();

        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }
        
        public Category GetCategory(int id)
        {
            return _categoryRepository.Get(id);
        }
    }
}
