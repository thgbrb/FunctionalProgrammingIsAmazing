using Microsoft.EntityFrameworkCore;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QueryScoreBoard.Repository.Repository
{
    public class GenericRepository<TEntity> : Repository.IGenericRepository<TEntity> where TEntity : EntityBase
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
            return _dbSet.ToListAsync<TEntity>().Result;
        }

        public TEntity FindBy(long id)
        {
            return _dbSet.FirstOrDefaultAsync<TEntity>(o => o.Id == id).Result;
        }
    }
}
