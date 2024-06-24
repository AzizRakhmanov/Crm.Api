using Crm.Entities.Models;

namespace Crm.DAL.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Student> Students { get;}

        public void Dispose();
     
        public Task<bool> SaveChanges();
    }
}
