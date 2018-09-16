using WebStore.Domain.Commands.CustomerCommands;

namespace WebStore.Domain.Validations.CustomerValidations
{
    public class DeleteCustomerCommandValidation : CustomerValidation<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}