using System;
using UnitTests.Repositories;
using WebStore.Domain.CommandHandlers;
using WebStore.Domain.Commands.AddressCommands;
using WebStore.Domain.Commands.CustomerCommands;
using WebStore.Domain.Enums;
using Xunit;

namespace UnitTests.CommandHandlers
{
    public class CustomerCommandHandlerTests
    {
        [Fact]
        public void ShouldCreateCustomer_When_CommandIsValid()
        {
            var command = new CreateCustomerCommand("James Bond", "james.bond@domain.com", "+44 1111 1111");
            var handler = new CustomerCommandHandler(new CustomerRepositoryMock());

            var result = handler.Handle(command);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void ShouldNotCreateCustomer_When_CommandIsInvalid()
        {
            var command = new CreateCustomerCommand("", "", "");
            var handler = new CustomerCommandHandler(new CustomerRepositoryMock());

            var result = handler.Handle(command);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void ShouldCreateAddress_When_CommandIsValid()
        {
            var command = new CreateAddressCommand("Street One", "London", "LND", "England", "77777", EAddressType.Billing, Guid.NewGuid());
            var handler = new CustomerCommandHandler(new CustomerRepositoryMock());

            var result = handler.Handle(command);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void ShouldNotCreateAddress_When_CommandIsInvalid()
        {
            var command = new CreateAddressCommand("", "", "", "", "", EAddressType.Billing, Guid.NewGuid());
            var handler = new CustomerCommandHandler(new CustomerRepositoryMock());

            var result = handler.Handle(command);

            Assert.False(result.IsValid);
        }
    }
}