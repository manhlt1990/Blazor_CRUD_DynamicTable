using Blazor.DynamicTable.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DynamicTable
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private readonly DynamicTableDBContext _context;
        public Repository(DynamicTableDBContext context)
        {
            _context = context;
        }

        private DbSet<TEntity> _entities;
        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity>();

                return _entities;
            }
        }


        public IQueryable<TEntity> Table => Entities;

        public IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();

        public void Delete(TEntity entity)
        {
            Entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            Entities.RemoveRange(entities);
            _context.SaveChanges();
        }

        public TEntity GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(TEntity entity)
        {
            Entities.Add(entity);
            _context.SaveChanges();
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            Entities.AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Entities.Update(entity);
            _context.SaveChanges();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            Entities.UpdateRange(entities);
            _context.SaveChanges();
        }
    }
}
