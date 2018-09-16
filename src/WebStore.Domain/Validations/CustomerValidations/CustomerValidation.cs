using System;
using FluentValidation;
using WebStore.Domain.Commands.CustomerCommands;

namespace WebStore.Domain.Validations.CustomerValidations
{
    public abstract class CustomerValidation<T> : AbstractValidator<T> where T : CustomerCommand
    {
        public void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
        
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please inform a name")
                .Length(2, 150).WithMessage("Name must have between 2 and 150 characters");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Please inform an email")
                .EmailAddress();
        }

        protected void ValidatePhone()
        {
            RuleFor(c => c.Phone)
                .NotEmpty().WithMessage("Please inform a phone");
        }
    }
}