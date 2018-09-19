using System;
using WebStore.Domain.Commands.AddressCommands;
using WebStore.Domain.Entities;
using WebStore.Domain.Repositories;
using WebStore.Shared.Commands;

namespace WebStore.Domain.CommandHandlers
{
    public class AddressCommandHandler :
        ICommandHandler<CreateAddressCommand>,
        ICommandHandler<DeleteAddressCommand>
    {
        private readonly IAddressRepository _repository;

        public AddressCommandHandler(IAddressRepository repository)
        {
            _repository = repository;
        }

        public CommandResult Handle(CreateAddressCommand command)
        {
            var result = command.Validate();

            if (result.IsValid)
            {
                var address = new Address(Guid.NewGuid(), command.Street, command.City, command.State, command.Country, command.ZipCode, command.Type);
                _repository.Add(address);
                result.Value = address;
            }

            return result;
        }

        public CommandResult Handle(DeleteAddressCommand command)
        {
            var result = command.Validate();

            if (result.IsValid)
            {
                //var address = new Address(command.Id, command.Street, command.City, command.State, command.Country, command.ZipCode, command.Type);
                _repository.Delete(command.Id);
            }

            return result;
        }
    }
}