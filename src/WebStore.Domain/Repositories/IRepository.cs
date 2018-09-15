using System;
using System.Collections.Generic;
using WebStore.Shared.Entities;

namespace WebStore.Domain.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(Guid id);
        IEnumerable<T> ListAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}