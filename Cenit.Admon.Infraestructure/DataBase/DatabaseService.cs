using Cenit.Admon.Domain.Entities.Customers;
using Cenit.Admon.Infraestructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Cenit.Admon.Infraestructure.DataBase
{
    public class DatabaseService : DbContext
    {
        public DatabaseService()
        {


        }
        public DatabaseService(DbContextOptions options) : base(options)
        {
           

        }
        public DbSet<CustomersEntity> CampanasEntity { get; set; }
        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfuguration(modelBuilder);
        }
        private void EntityConfuguration(ModelBuilder modelBuilder)
        {
            new CustomerConfiguration(modelBuilder.Entity<CustomersEntity>());
        }

    }
}
