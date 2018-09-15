using UnitTests.Repositories;
using WebStore.Domain.CommandHandlers;
using WebStore.Domain.Commands.CustomerCommands;
using Xunit;

namespace UnitTests.CommandHandlers
{
    public class CustomerCommandHandlerTests
    {
        [Fact]
        public void ShouldCreate_When_CommandIsValid()
        {
            var command = new CreateCustomerCommand("James Bond", "james.bond@domain.com", "+44 1111 1111");
            var handler = new CustomerCommandHandler(new CustomerRepositoryMock());

            var result = handler.Handle(command);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void ShouldNotCreate_When_CommandIsInvalid()
        {
            var command = new CreateCustomerCommand("", "", "");
            var handler = new CustomerCommandHandler(new CustomerRepositoryMock());

            var result = handler.Handle(command);

            Assert.False(result.IsValid);            
        }
    }
}