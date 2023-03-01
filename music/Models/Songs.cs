using System.ComponentModel.DataAnnotations;

namespace music.Models
{
    public class Songs
    {
        [Key]
        public int Song_Id { get; set; }

        public TimeSpan Duration { get; set; }
        public DateTime Added_date { get; set; }
        public string artist { get; set; }
    }
}
