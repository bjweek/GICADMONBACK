using AutoMapper;
using Cenit.Admon.Application.Customers.Commands;
using Cenit.Admon.Domain.Entities.Customers;
using Cenit.Admon.Domain.Services.Interfaces;
using MediatR;

namespace Cenit.Admon.Application.Customers.Handlers
{

    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        #region fields 
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        #endregion
        public CreateCustomerCommandHandler(ICustomerService customer, IMapper mapper)
        {
            _customerService = customer;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateCustomerCommand command, CancellationToken cancellation)
        {
            var customeerentity = _mapper.Map<CustomersEntity>(command.Customer);
            _customerService.Add(customeerentity);
            return false;
        }
    }
}
