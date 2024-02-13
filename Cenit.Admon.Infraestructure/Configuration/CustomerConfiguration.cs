using Cenit.Admon.Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cenit.Admon.Infraestructure.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomersEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdCustomer);
        }
    }
}
