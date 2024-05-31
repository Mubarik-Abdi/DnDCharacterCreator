using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Race
    {
        [Key]
        public int Race_id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
    }
}
