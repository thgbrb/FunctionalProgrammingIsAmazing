using QueryScoreBoard.Core.Entity.SQLMonitor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QueryScoreBoard.Repository.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> FindBy(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public void Delete(long id)
        {
            _context.Set<TEntity>().Remove(FindBy(id));
        }

        public List<TEntity> FindAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity FindBy(long id)
        {
            return _context.Set<TEntity>().FirstOrDefault(o => o.Id == id);
        }
    }
}
