using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ImalatMontaj.Core.DataAccess
{
    public interface IEntityRepository<TEntity>
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        List<TEntity> GetList(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            int page = 1,
            int pageSize = 0,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null
            );

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
