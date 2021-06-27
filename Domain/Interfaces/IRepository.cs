using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Specification;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id); 
        Task<List<T>> ListAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        void Update(T entity);
        Task UpdateMany(List<Product> spec);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IList<T> entity);
        Task<T> GetBySpecification(ISpecification<T> spec);
        Task<List<T>> GetAllBySpecification(ISpecification<T> spec);
    }
}