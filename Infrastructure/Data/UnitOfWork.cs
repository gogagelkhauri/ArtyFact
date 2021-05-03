using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;
        private ApplicationDbContext _applicationDbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _applicationDbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
            _applicationDbContext.SaveChanges();
        }

        public void Rollback()
        {
            _dbContext.Dispose(); 
            _applicationDbContext.Dispose(); 
        }
    }
}