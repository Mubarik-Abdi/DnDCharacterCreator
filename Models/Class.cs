using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Class
    {
        [Key]
        public int Class_id { get; set; }
        public string Class_Name { get; set; }
        public string Hit_die { get; set; }
        public string Save_proficiencies { get; set; }
        public string Description { get; set; }
    }
}
