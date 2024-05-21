namespace Server.API.Models
{
    public class MarketBuyItem
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public int BuyPrice { get; set; }
    }
}
