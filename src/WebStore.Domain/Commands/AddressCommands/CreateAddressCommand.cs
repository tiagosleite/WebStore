using System;
using FluentValidation.Results;
using WebStore.Domain.Enums;
using WebStore.Domain.Validations.AddressValidations;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.AddressCommands
{
    public class CreateAddressCommand : AddressCommand
    {
        public Guid CustomerId { get; set; }

        public CreateAddressCommand(string street, string city, string state, string country, string zipCode, EAddressType type, Guid customerId)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = type;
            CustomerId = customerId;
        }
        
        public override CommandResult Validate()
        {
            ValidationResult validationResult = new CreateAddressCommandValidation().Validate(this);
            return new CommandResult(validationResult);
        }
    }
}