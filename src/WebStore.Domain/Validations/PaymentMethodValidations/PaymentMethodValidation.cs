using FluentValidation;
using WebStore.Domain.Commands.PaymentMethodCommands;

namespace WebStore.Domain.Validations.PaymentMethodValidations
{
    public abstract class PaymentMethodValidation<T> : AbstractValidator<T> where T : PaymentMethodCommand
    {
        public void ValidateAlias()
        {
            RuleFor(pm => pm.Alias)
                .NotEmpty().WithMessage("Please inform card alias");
        }

        public void ValidateCardId()
        {
            RuleFor(pm => pm.CardId)
                .NotEmpty().WithMessage("Please inform card id");
        }

        public void ValidateLast4()
        {
            RuleFor(pm => pm.Last4)
                .NotEmpty().WithMessage("Please inform last 4 digits");
        }
    }
}