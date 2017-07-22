using System;
using System.Collections.Generic;
using System.Text;

namespace QueryScoreBoard.Repository.Repository
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> FindAll();
        TEntity FindBy(long id);
        IEnumerable<TEntity> FindBy(Func<TEntity, bool> predicate);
        void Delete(long id);
        void Add(TEntity entity);
    }
}
