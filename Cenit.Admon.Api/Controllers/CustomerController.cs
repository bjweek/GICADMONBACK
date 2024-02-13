using Cenit.Admon.Application.Customers.Commands;
using Cenit.Admon.Application.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cenit.Admon.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        #region fields
        private readonly IMediator _mediator;
        #endregion

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ExceptionRequestDto))]
        //[ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(ExceptionRequestDto))]
        public async Task<ActionResult<bool>> CreateCustomer([FromBody] CustomerDto body)
        {
            return StatusCode(StatusCodes.Status201Created, await _mediator.Send(new CreateCustomerCommand
            {
                Customer = body
            }));
        }
       


    }
}
