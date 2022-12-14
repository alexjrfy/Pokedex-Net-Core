using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Create(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(Guid id);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}