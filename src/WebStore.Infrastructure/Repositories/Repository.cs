using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Domain.Repositories;
using WebStore.Infrastructure.Contexts;
using WebStore.Shared.Entities;

namespace WebStore.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly WebStoreContext _context;

        public Repository(WebStoreContext context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete(Guid id)
        {
            _context.Set<T>().Remove(_context.Set<T>().Find(id));
            _context.SaveChanges();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> ListAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}