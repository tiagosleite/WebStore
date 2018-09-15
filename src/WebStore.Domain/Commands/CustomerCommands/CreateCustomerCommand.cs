using FluentValidation.Results;
using WebStore.Domain.Validations.CustomerValidations;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.CustomerCommands
{
    public class CreateCustomerCommand : CustomerCommand
    {
        public CreateCustomerCommand(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
        
        public override CommandResult Validate()
        {
            ValidationResult validationResult = new CreateCustomerCommandValidation().Validate(this);
            return new CommandResult(validationResult);
        }
    }
}