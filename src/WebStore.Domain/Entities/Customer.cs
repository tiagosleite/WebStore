using System;
using System.Collections.Generic;
using WebStore.Shared.Entities;

namespace WebStore.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(Guid id, string name, string email, string phone)
            : base(id)
        {
            Name = name;
            Email = email;
            Phone = phone;

            _addresses = new List<Address>();
            _paymentMethods = new List<PaymentMethod>();
        }

        private readonly List<Address> _addresses;
        private readonly List<PaymentMethod> _paymentMethods;

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.AsReadOnly();
        public IReadOnlyCollection<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();

        public void AddAddress(Address address)
        {
            // TODO: Implement
        }

        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            // TODO: Implement
        }
    }
}