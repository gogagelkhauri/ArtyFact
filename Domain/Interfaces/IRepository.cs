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
        Task DeleteAsync(T entity);
        Task<T> GetBySpecification(ISpecification<T> spec);
        //void TryUpdateManyToMany<T, TKey>(IEnumerable<T> currentItems, IEnumerable<T> newItems, Func<T, TKey> getKey);
    }
}