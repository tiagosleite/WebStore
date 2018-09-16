using WebStore.Domain.Commands.CustomerCommands;

namespace WebStore.Domain.Validations.CustomerValidations
{
    public class UpdateCustomerCommandValidation : CustomerValidation<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateEmail();
            ValidatePhone();
        }
    }
}