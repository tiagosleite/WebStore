using WebStore.Domain.Commands.AddressCommands;

namespace WebStore.Domain.Validations.AddressValidations
{
    public class CreateAddressCommandValidation : AddressValidation<CreateAddressCommand>
    {
        public CreateAddressCommandValidation()
        {
            ValidateStreet();
            ValidateCity();
            ValidateState();
            ValidateCountry();
            ValidateZipCode();
        }
    }
}