using System.Collections.Generic;

namespace WebStore.Domain.Entities
{
    public class Customer
    {
        public Customer(string name, string email, string phone)
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
    }
}