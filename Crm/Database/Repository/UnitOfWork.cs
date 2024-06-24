using Crm.DAL.IRepository;
using Crm.Database;
using Crm.Database.DbContexts;
using Crm.Entities.Models;
using System.Runtime.CompilerServices;

namespace Crm.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccess _dataAccess;

        public UnitOfWork(DataAccess dataAccess) 
        {
            this._dataAccess = dataAccess;

            Students = new Repository<Student>(this._dataAccess);

            
        }
        public IRepository<Student> Students { get; private set; }

     


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async  Task<bool> SaveChanges()
        {
            return await this._dataAccess.SaveChangesAsync() >= 0;
        }
    }
}
