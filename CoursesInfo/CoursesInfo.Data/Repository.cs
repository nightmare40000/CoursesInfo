using System.Collections.Generic;
using CoursesInfo.Core;
using CoursesInfo.Core.Entities;

namespace CoursesInfo.Data
{
    public abstract class Repository<T> : IRepository<T>
        where T:EntitiesObject
    {
        public abstract T Get(object id);
        
        public abstract IEnumerable<T> GetAll();
        
       // public abstract IList<Comment> GetNewsCommet();

        public abstract void Save(T entity);

        public void Save(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Save(entity);
            }
        }

        public abstract void Delete(object id);

        public abstract void Delete(T entity);
    }
}
