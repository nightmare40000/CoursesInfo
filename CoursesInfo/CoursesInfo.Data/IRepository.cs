using System.Collections.Generic;
using CoursesInfo.Core;

namespace CoursesInfo.Data
{
    public interface IRepository<T>
        where T:EntitiesObject
    {
        T Get(object id);
        
        IEnumerable<T> GetAll();

        void Save(T entity);

        void Save(IEnumerable<T> entities);

        void Delete(object id);

        void Delete(T entity);
    }
}