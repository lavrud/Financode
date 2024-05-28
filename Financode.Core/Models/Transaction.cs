using Financode.Core.Enums;

namespace Financode.Core.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? PairOrReceivedAt { get; set; }

        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        public long CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;
    }
}