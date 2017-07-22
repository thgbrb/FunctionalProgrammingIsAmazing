using System;
using System.Collections.Generic;

namespace QueryScoreBoard.Repository.Repository
{
    public interface IGenericRepository<TEntity>
    {
        List<TEntity> FindAll();
        TEntity FindBy(long id);
        IEnumerable<TEntity> FindBy(Func<TEntity, bool> predicate);
        void Delete(long id);
        void Add(TEntity entity);
    }
}
