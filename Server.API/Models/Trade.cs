namespace Server.API.Models
{
    public class Trade
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ResourceToGiveId { get; set; }
        public int ResourceToGiveQuantity { get; set; }
        public Guid ResourceToGetResourceId { get; set; }
        public int ResourceToGetQuantity { get; set; }
        public DateTime TradeCreationTime { get; set; }
        public bool IsCompleted { get; set; }
    }
}
