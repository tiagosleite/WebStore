using WebStore.Shared.Commands;

namespace WebStore.Domain.Commands.PaymentMethodCommands
{
    public abstract class PaymentMethodCommand : Command
    {
        public string Alias { get; set; }
        public string CardId { get; set; }
        public string Last4 { get; set; }
    }
}