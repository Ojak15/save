using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test2.Models
{
    public class Player
    {
        [Key]
        public int Player_id { get; set; }

        public string? Name { get; set; }
        // [ForeignKey("team_id")]
        public string? TeamName { get; set; }

        public string? Points { get; set; }

        public string? Rebounds { get; set; }

        public string? Assists { get; set; }

        public string? Blocks { get; set; }

        public string? Steals { get; set; }
    }
}