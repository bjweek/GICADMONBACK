using Cenit.Admon.Domain.Entities.Customers;
using Cenit.Admon.Domain.Services.Interfaces;
using Cenit.Admon.Infraestructure.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Cenit.Admon.Infraestructure.Repositories
{
    public class CustomerRepository : EntityRepository<CustomersEntity>, ICustomerService
    {
        private readonly DatabaseService context;

        public CustomerRepository(DatabaseService context) : base(context)
        {
            this.context = context;
        }

        public bool Save(string id)
        {
            var result2 = context.Database.SqlQueryRaw<CustomersEntity>($"EXEC " + Enums.EnumProcedure.SPGetCustomer).ToList();
            return true;
        }

    }
}
