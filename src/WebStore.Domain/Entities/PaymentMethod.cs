namespace WebStore.Domain.Entities
{
    public class PaymentMethod
    {
        public PaymentMethod(string alias, string cardId, string last4)
        {
            Alias = alias;
            CardId = cardId;
            Last4 = last4;
        }

        public string Alias { get; private set; }
        public string CardId { get; private set; }
        public string Last4 { get; private set; }
    }
}