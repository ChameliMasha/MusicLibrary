using System.ComponentModel.DataAnnotations;

namespace music.Models
{
    public class user
    {
        [Key]
        public long User_Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string User_mobile { get; set; }
        public string age { get; set; }


    }
}

