using System.ComponentModel.DataAnnotations;

namespace music.Models
{
    public class Artist
    {
        [Key]
        public long Artist_Id { get; set; } 
        public string Artist_name { get; set; }
        public long Bio { get; set; }
        public string Photo { get; set; }


    }
}
