using WebStore.Domain.Enums;

namespace WebStore.Domain.Entities
{
    public class Address
    {
        public Address(string street, string city, string state, string country, string zipCode, EAddressType type)
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
    }
}