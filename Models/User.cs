using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class User
    {
        [Key]
        public int Userid { get; set; }

        public int League_id { get; set; }

        public string Username { get; set; }

        public String Userpassword { get; set; }
    }
}
