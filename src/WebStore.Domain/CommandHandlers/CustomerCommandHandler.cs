using System;
using WebStore.Domain.Commands;
using WebStore.Domain.Commands.CustomerCommands;
using WebStore.Domain.Entities;
using WebStore.Domain.Repositories;
using WebStore.Shared.Commands;

namespace WebStore.Domain.CommandHandlers
{
    public class CustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository _repository;
        public CustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public CommandResult Handle(CreateCustomerCommand command)
        {
            var result = command.Validate();

            if (_repository.GetByEmail(command.Email) != null)
                result.Messages.Add("Email has already been taken");
            
            if (result.IsValid)
                result.Value = _repository.Add(new Customer(Guid.NewGuid(), command.Name, command.Email, command.Phone));
            
            return result;

        }
    }
}