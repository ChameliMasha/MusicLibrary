using System.ComponentModel.DataAnnotations;

namespace music.Models
{
    public class UserProfile
    {
        [Key]
        public int UP_Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Photo { get; set; }

        //public List<Album> Albums { get; set; }
        public List<Playlist> Playlists { get; set; }

    }

}
