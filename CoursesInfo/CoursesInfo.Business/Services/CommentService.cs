using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Core.Entities;
using CoursesInfo.Data;

namespace CoursesInfo.Business.Services
{
    public class CommentService:Service
    {
        private readonly NHibernateRepository<News> _commentRepository
            = new NHibernateRepository<News>();
        
        public IList<News> GetAllNewsComment(int id)
        {
            return _commentRepository.GetNewsComment(id);
        }
    }
}
