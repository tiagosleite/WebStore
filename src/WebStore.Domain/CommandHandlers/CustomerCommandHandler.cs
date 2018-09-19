using System;
using WebStore.Domain.Commands;
using WebStore.Domain.Commands.AddressCommands;
using WebStore.Domain.Commands.CustomerCommands;
using WebStore.Domain.Commands.PaymentMethodCommands;
using WebStore.Domain.Entities;
using WebStore.Domain.Repositories;
using WebStore.Shared.Commands;

namespace WebStore.Domain.CommandHandlers
{
    public class CustomerCommandHandler :
        ICommandHandler<CreateCustomerCommand>,
        ICommandHandler<CreatePaymentMethodCommand>,
        ICommandHandler<UpdateCustomerCommand>,
        ICommandHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAddressRepository _addressRepository;

        public CustomerCommandHandler(ICustomerRepository customerRepository, IAddressRepository addressRepository)
        {
            _customerRepository = customerRepository;
            _addressRepository = addressRepository;
        }

        public CommandResult Handle(CreateCustomerCommand command)
        {
            var result = command.Validate();

            if (_customerRepository.GetByEmail(command.Email) != null)
                result.Messages.Add("Email has already been taken");

            if (result.IsValid)
                result.Value = _customerRepository.Add(new Customer(Guid.NewGuid(), command.Name, command.Email, command.Phone));

            return result;

        }

        public CommandResult Handle(CreatePaymentMethodCommand command, Guid customerId)
        {
            command.CustomerId = customerId;
            return Handle(command);
        }

        public CommandResult Handle(CreatePaymentMethodCommand command)
        {
            var result = command.Validate();

            var customer = _customerRepository.GetById(command.CustomerId);

            if(customer == null)
            {
                result.Messages.Add("Customer not found with the given Id");
                return result;
            }

            if(result.IsValid)
            {
                var paymentMethod = new PaymentMethod(Guid.NewGuid(), command.Alias, command.CardId, command.Last4);
                customer.AddPaymentMethod(paymentMethod);
                _customerRepository.Update(customer);
                result.Value = customer;
            }

            return result;
        }

        public CommandResult Handle(UpdateCustomerCommand command)
        {
            var result = command.Validate();
            
            var customerInDb = _customerRepository.GetById(command.Id);

            if(customerInDb == null)
                result.Messages.Add("Customer not found with the given Id");

            if(result.IsValid)
            {
                var customer = new Customer(command.Id, command.Name, command.Email, command.Phone);
                _customerRepository.Update(customer);
                result.Value = customer;
            }
            
            return result;
        }

        public CommandResult Handle(DeleteCustomerCommand command)
        {
            var result = command.Validate();

            if(result.IsValid)
            {
                // var customer = new Customer(command.Id, command.Name, command.Email, command.Phone);
                _customerRepository.Delete(command.Id);
            }

            return result;
        }
    }
}