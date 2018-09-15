using WebStore.Domain.Commands.CustomerCommands;

namespace WebStore.Domain.Validations.CustomerValidations
{
    public class CreateCustomerCommandValidation : CustomerValidation<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidation()
        {
            ValidateName();
            ValidateEmail();
            ValidatePhone();
        }
    }
}