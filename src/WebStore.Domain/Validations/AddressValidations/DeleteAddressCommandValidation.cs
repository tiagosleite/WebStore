using WebStore.Domain.Commands.AddressCommands;

namespace WebStore.Domain.Validations.AddressValidations
{
    public class DeleteAddressCommandValidation : AddressValidation<DeleteAddressCommand>
    {
        public DeleteAddressCommandValidation()
        {
            ValidateId();
        }
    }
}