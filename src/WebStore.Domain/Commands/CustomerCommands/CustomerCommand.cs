using System;
using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.CustomerCommands
{
    public abstract class CustomerCommand : Command
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}