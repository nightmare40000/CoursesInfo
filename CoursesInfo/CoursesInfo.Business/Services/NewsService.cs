using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using CoursesInfo.Data;

namespace CoursesInfo.Business.Services
{
    class NewsService:Service
    {
        private readonly IRepository<News> _newsRepository
            = new NHibernateRepository<News>();

        public IEnumerable<News> GetAllNews()
        {
            return _newsRepository.GetAll();
        }
    }
}
