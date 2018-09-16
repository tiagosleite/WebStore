using System;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.CommandHandlers;
using WebStore.Domain.Commands.AddressCommands;
using WebStore.Domain.Commands.CustomerCommands;
using WebStore.Domain.Repositories;

namespace WebStore.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _repository;
        private readonly CustomerCommandHandler _handler;
        public CustomersController(ICustomerRepository repository, CustomerCommandHandler handler)
        {
            _handler = handler;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.ListAll());
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var customer = _repository.GetByIdWithAddressesAndPaymentMethods(id);

            if (customer == null)
                return NotFound();
            
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post([FromBody]CreateCustomerCommand command)
        {
            var result = _handler.Handle(command);

            if(!result.IsValid)
                return BadRequest(result);
            
            return Ok(result);
        }

        [HttpPost("{customerId:guid}/address")]
        public IActionResult Post(Guid customerId, [FromBody]CreateAddressCommand command)
        {
            var result = _handler.Handle(command, customerId);
            
            if(!result.IsValid)
                return BadRequest(result);
            
            return Ok(result);
        }
    }
}