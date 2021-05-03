using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.Infrastructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public EfRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public Task<T> GetByIdAsync(int id) 
        {
            return _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> GetBySpecification(ISpecification<T> spec) 
        {
            var specificationResult = ApplySpecification(spec);
            return await specificationResult.FirstAsync();
        }

        public Task<List<T>> ListAsync() 
        {
            return _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity) 
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public Task UpdateAsync(T entity) 
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }
        public void Update(T entity) 
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task DeleteAsync(T entity) 
        {
            _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            var evaluator = new SpecificationEvaluator<T>();
            return evaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }

        public void UpdateMany(ISpecification<T> spec)
        {
            var entity = this.GetBySpecification(spec);
            //_dbContext.TryUpdateManyToMany();
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChangesAsync();
        }

        public void TryUpdateManyToMany<T, TKey>(IEnumerable<T> currentItems, IEnumerable<T> newItems, Func<T, TKey> getKey) where T : BaseEntity
        {
            // _dbContext.Set<T>().RemoveRange(currentItems.Except(newItems, getKey));
            // _dbContext.Set<T>().AddRange(newItems.Except(currentItems, getKey));
            _dbContext.TryUpdateManyToMany(currentItems,newItems,getKey);
        }

    }
}