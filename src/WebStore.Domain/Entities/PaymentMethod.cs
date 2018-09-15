using System;
using WebStore.Shared.Entities;

namespace WebStore.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public PaymentMethod(Guid id, string alias, string cardId, string last4)
            : base(id)
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