using Cenit.Admon.Application.DTO;
using MediatR;

namespace Cenit.Admon.Application.Customers.Commands
{
    public class CreateCustomerCommand : IRequest<bool>
    {
        public CustomerDto Customer { get; set; }   
    }
}
