using Microsoft.EntityFrameworkCore;
using Server.API.Models;
namespace Server.API.Utils
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options) : base(options)
        {
        }

        public DbSet<InventoryResource> InventoryResources { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FarmCell> FarmCells { get; set; }
        public DbSet<Font> Fonts { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<MarketSellResource> MarketSellResources { get; set; }
        public DbSet<MarketBuyItem> MarketBuyItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PlayingCard> PlayingCards { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Trade> Trades { get; set; }
    }
}
