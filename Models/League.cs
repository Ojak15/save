using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models
{
    public class League
    {
        [Key]
        public int League_id { get; set; }

        public string? Leaguename { get; set; }

        public string? LeagueDescription { get; set; }

        public string? Level { get; set; }
    }
}