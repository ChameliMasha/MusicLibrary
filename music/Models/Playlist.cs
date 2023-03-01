using System.ComponentModel.DataAnnotations;

namespace music.Models
{
    public class Playlist
    {
        [Key]
        public int Playlist_Id { get; set; }
        public string Playlist_Name { get; set; }
        public long Description { get; set; }
        public List<Songs> Songs { get; set; }
    }
}
