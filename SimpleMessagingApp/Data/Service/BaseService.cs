using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SimpleMessagingApp.Data.Service
{
    public class BaseService<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entitySet;

        public BaseService(DbContext context)
        {
            _context = context;
            _entitySet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entitySet.ToList();
        }

        public TEntity? GetById(object id)
        {
            var result = _entitySet.Find(id);
            return result;
        }

        public TEntity Add(TEntity entity)
        {
            _entitySet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public void Delete(object id)
        {
            var entity = _entitySet.Find(id);
            if (entity != null)
            {
                _entitySet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TEntity> GetAllByFiltered(Expression<Func<TEntity, bool>> filter)
        {
            return _entitySet.Where(filter).ToList();
        }
    }
}