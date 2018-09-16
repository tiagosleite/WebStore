using System;
using WebStore.Domain.Enums;
using WebStore.Shared.Entities;

namespace WebStore.Domain.Entities
{
    public class Address : BaseEntity
    {
        public Address(Guid id, string street, string city, string state, string country, string zipCode, EAddressType type)
            : base(id)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = type;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAddressType Type { get; private set; }
        public Guid CustomerId { get; private set; }

        public void SetCustomerId(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}