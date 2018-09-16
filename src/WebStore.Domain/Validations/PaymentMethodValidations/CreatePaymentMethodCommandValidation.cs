using WebStore.Domain.Commands.PaymentMethodCommands;

namespace WebStore.Domain.Validations.PaymentMethodValidations
{
    public class CreatePaymentMethodCommandValidation : PaymentMethodValidation<CreatePaymentMethodCommand>
    {
        public CreatePaymentMethodCommandValidation()
        {
            ValidateAlias();
            ValidateCardId();
            ValidateLast4();
        }
    }
}