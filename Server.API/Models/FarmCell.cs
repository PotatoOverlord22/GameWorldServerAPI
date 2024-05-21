using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Server.API.Models
{
    [PrimaryKey("Id")]

    public class FarmCell
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Item Item { get; set; }
        public DateTime? LastTimeEnhanced { get; set; } // Nullable.
        public DateTime? LastTimeInteracted { get; set; } // Nullable.
    }
}
