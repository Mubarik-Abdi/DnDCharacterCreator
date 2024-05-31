using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Classes
    {
        [Key]
        public int Classes_id { get; set; }
        public string Artificer { get; set; }
        public string Barbarian { get; set; }
        public string Bard { get; set; }
        public string Cleric { get; set; }
        public string Druid { get; set; }
        public string Fighter { get; set; }
        public string Monk { get; set; }
        public string Paladin { get; set; }
        public string Ranger { get; set; }
        public string Rogue { get; set; }
        public string Sorcerer { get; set; }
        public string Warlock { get; set; }
        public string Wizard { get; set; }
    }
}
