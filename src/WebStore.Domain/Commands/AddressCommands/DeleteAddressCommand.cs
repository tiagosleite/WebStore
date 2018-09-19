using System;
using FluentValidation.Results;
using WebStore.Domain.Validations.AddressValidations;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.AddressCommands
{
    public class DeleteAddressCommand : AddressCommand
    {
        public DeleteAddressCommand(Guid id)
        {
            Id = id;
        }
        
        public override CommandResult Validate()
        {
            ValidationResult validationResult = new DeleteAddressCommandValidation().Validate(this);
            return new CommandResult(validationResult);
        }
    }
}