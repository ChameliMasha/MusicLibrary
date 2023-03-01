using System.ComponentModel.DataAnnotations;

namespace music.Models
{
    public class Login
    {
        [Key]
        public long Login_Id { get; set; }
        public string Password { get; set; }
        public string User_name { get; set; }
    }
}
