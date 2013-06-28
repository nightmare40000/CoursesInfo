using System.Collections.Generic;
using CoursesInfo.Core;
using CoursesInfo.Core.Entities;

namespace CoursesInfo.Data
{
    public interface IRepository<T>
        where T:EntitiesObject
    {
        T Get(object id);
        
        IEnumerable<T> GetAll();

      //  IList<Comment> GetNewsCommet();

        void Save(T entity);

        void Save(IEnumerable<T> entities);

        void Delete(object id);

        void Delete(T entity);
    }
}