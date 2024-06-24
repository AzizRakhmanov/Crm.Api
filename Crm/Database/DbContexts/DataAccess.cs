using Crm.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Crm.Database.DbContexts
{
    public class DataAccess : DbContext
    {
        public DataAccess(DbContextOptions<DataAccess> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
