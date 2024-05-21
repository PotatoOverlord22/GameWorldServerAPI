namespace Server.API.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public ShopItem(int id, string imagePath, string name, int price)
        {
            Id = id;
            ImagePath = imagePath;
            Name = name;
            Price = price;
        }
    }
}
