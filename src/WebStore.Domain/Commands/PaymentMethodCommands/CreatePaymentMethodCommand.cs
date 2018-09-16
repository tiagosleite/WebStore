using System;
using FluentValidation.Results;
using WebStore.Domain.Validations.PaymentMethodValidations;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.PaymentMethodCommands
{
    public class CreatePaymentMethodCommand : PaymentMethodCommand
    {
        public Guid CustomerId { get; set; }

        public CreatePaymentMethodCommand(string alias, string cardId, string last4, Guid customerId)
        {
            Alias = alias;
            CardId = cardId;
            Last4 = last4;
            CustomerId = customerId;
        }

        public override CommandResult Validate()
        {
            ValidationResult validationResult = new CreatePaymentMethodCommandValidation().Validate(this);
            return new CommandResult(validationResult);
        }
    }
}