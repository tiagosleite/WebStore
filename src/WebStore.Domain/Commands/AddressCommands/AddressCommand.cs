using System;
using WebStore.Domain.Enums;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.AddressCommands
{
    public abstract class AddressCommand : Command
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public EAddressType Type { get; set; }
    }
}