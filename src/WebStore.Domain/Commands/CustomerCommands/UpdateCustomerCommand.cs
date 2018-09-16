using System;
using FluentValidation.Results;
using WebStore.Domain.Validations.CustomerValidations;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.CustomerCommands
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(Guid id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }
        public override CommandResult Validate()
        {
            ValidationResult validationResult = new UpdateCustomerCommandValidation().Validate(this);
            return new CommandResult(validationResult);
        }
    }
}