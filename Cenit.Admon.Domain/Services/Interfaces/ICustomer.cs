using Cenit.Admon.Domain.Entities.Customers;
using Cenit.Admon.Domain.Services.IRepository;

namespace Cenit.Admon.Domain.Services.Interfaces
{
    public interface ICustomerService : IRepository<CustomersEntity>
    {
        bool Save(string id);
       
    }
}
