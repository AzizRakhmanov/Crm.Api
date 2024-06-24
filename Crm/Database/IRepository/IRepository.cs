using System.Data;
using System.Linq.Expressions;

namespace Crm.DAL.IRepository
{
    public interface IRepository<TEntity>
    {
        public ValueTask<TEntity> InsertEntity(Expression<Func<TEntity, bool>> expression);

        public TEntity Update(TEntity tEntity);

        public IQueryable<TEntity> SelectAll(Expression<Func<TEntity,bool>> expression);

        public ValueTask<IQueryable<TEntity>> SelectAsync(Expression<Func<TEntity,bool>> expression);

        public ValueTask<bool> DeleteAsync(Expression<Func<TEntity,bool>> expression);

        public bool DeleteMany(Expression<Func<TEntity,bool>> expression);

        ValueTask SaveAsync();
    }

}
