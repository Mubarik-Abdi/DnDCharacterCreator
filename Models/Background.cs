using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Background
    {
        [Key]
        public int Background_id { get; set; }
        public string Background_name { get; set; }
        public string Bonds { get; set; }
        public string Ideals { get; set; }
        public string Flaws { get; set; }
    }
}
