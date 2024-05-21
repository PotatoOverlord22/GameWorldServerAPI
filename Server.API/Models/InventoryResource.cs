namespace Server.API.Models
{
    public class InventoryResource
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public Guid ResourceId { get; set; }
        public int Quantity { get; set; }
    }
}
