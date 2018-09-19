using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.CommandHandlers;
using WebStore.Domain.Commands.AddressCommands;
using WebStore.Domain.Repositories;

namespace WebStore.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AddressesController : Controller
    {
        private readonly IAddressRepository _repository;
        private readonly AddressCommandHandler _handler;

        public AddressesController(IAddressRepository repository, AddressCommandHandler handler)
        {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.ListAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody]CreateAddressCommand command)
        {
            var result = _handler.Handle(command);

            if (!result.IsValid)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]DeleteAddressCommand command)
        {
            var result = _handler.Handle(command);

            if (!result.IsValid)
                return BadRequest(result);

            return Ok(result);
        }
    }
}