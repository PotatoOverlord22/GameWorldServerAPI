namespace Server.API.Models
{
    public class MarketSellResource
    {
        public Guid Id { get; set; }
        public Guid ResourceToSellId { get; set; }
        public int SellPrice { get; set; }
    }
}
