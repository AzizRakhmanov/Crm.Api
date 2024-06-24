using Crm.DAL.IRepository;
using Crm.Database.DbContexts;
using Crm.Entities.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Crm.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly DataAccess _dataAccess;

        private readonly DbSet<TEntity> _dbSet;

        public Repository(DataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
            this._dbSet = dataAccess.Set<TEntity>();
        }


        public async ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            var existingObject = await this._dbSet.FirstOrDefaultAsync(expression);

            if (existingObject is not null)
            {
                this._dbSet.Remove(existingObject);
                var result = this._dataAccess.SaveChanges();
                return result >= 0;
            }

            return existingObject is null;
        }

        public bool DeleteMany(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> InsertEntity(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ValueTask SaveAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IQueryable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity tEntity)
        {
            throw new NotImplementedException();
        }
    }
}
