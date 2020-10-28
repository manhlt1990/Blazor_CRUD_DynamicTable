using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DynamicTable
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> TableNoTracking { get; }
    }
}
