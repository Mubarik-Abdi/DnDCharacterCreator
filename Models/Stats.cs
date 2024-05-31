using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Stats
    {
        [Key]
        public int Character_id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Health { get; set; }
        public int Initiative { get; set; }
        public int Armor_class { get; set; }
    }
}
