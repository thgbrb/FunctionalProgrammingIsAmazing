using Microsoft.EntityFrameworkCore;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using System.Collections.Generic;

namespace QueryScoreBoard.Repository.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet; 

        public GenericRepository(DbContext context)
        {
            _context = context; 
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(long id)
        {
            _dbSet.Remove(FindBy(id));
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _dbSet.ToListAsync().Result;
        }

        public TEntity FindBy(long id)
        {
            return _dbSet.FirstOrDefaultAsync(o => o.Id == id).Result;
        }
    }
}
