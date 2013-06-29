using System.Collections;
using System.Collections.Generic;
using CoursesInfo.Core;
using CoursesInfo.Core.Entities;
using NHibernate;

namespace CoursesInfo.Data
{
    public class NHibernateRepository<T> : Repository<T>
        where T:EntitiesObject
    {
        private readonly ISession _session;

        public NHibernateRepository()
        {
            _session = DataBaseConfig.OpenSession();
        }

        public override T Get(object id)
        {
            return _session.Get<T>(id);
        }

        public override IEnumerable<T> GetAll()
        {
            return _session.QueryOver<T>().List();
        }

        public IList<News> GetNewsComment(int id)
        {
            return _session.QueryOver<News>()
                           .Where(x => x.Id == id)
                           .JoinQueryOver<Comment>(x => x.Comments)
                           .Where(x => x.ContentGroup == 1)
                           .List();
        }

        public override void Save(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(entity);
                transaction.Commit();
            }
        }

        public override void Delete(object id)
        {
            var entity = Get(id);
            Delete(entity);
        }

        public override void Delete(T entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                _session.Delete(entity);
                transaction.Commit();
            }
        }
    }
}
