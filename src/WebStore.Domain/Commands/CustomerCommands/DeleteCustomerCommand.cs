using System;
using FluentValidation.Results;
using WebStore.Domain.Validations.CustomerValidations;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.CustomerCommands
{
    public class DeleteCustomerCommand : CustomerCommand
    {
        public DeleteCustomerCommand(Guid id)
        {
            Id = id;
        }

        public override CommandResult Validate()
        {
            ValidationResult validationResult = new DeleteCustomerCommandValidation().Validate(this);
            return new CommandResult(validationResult);
        }
    }
}