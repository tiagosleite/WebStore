using System;
using FluentValidation;
using WebStore.Domain.Commands.AddressCommands;

namespace WebStore.Domain.Validations.AddressValidations
{
    public abstract class AddressValidation<T> : AbstractValidator<T> where T : AddressCommand
    {
        protected void ValidateId()
        {
            RuleFor(a => a.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateStreet()
        {
            RuleFor(a => a.Street)
                .NotEmpty().WithMessage("Please inform a street");
        }

        protected void ValidateCity()
        {
            RuleFor(a => a.City)
                .NotEmpty().WithMessage("Please inform a city");
        }

        protected void ValidateState()
        {
            RuleFor(a => a.State)
                .NotEmpty().WithMessage("Please inform a state");
        }

        protected void ValidateCountry()
        {
            RuleFor(a => a.Country)
                .NotEmpty().WithMessage("Please inform a country");
        }

        protected void ValidateZipCode()
        {
            RuleFor(a => a.ZipCode)
                .NotEmpty().WithMessage("Please inform a Zip Code");
        }
    }
}