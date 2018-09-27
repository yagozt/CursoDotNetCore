using StoreOfBuild.Data.Contexts;
using StoreOfBuild.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreOfBuild.Data.Repositores
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public virtual TEntity GetById(int id)
        {
            var query = _context.Set<TEntity>().Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public virtual IEnumerable<TEntity> All()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }

        public virtual void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }
    }
}
