using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Spells
    {
        [Key]
        public int Spell_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Spell_school { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Range { get; set; }
        public string Casting_time { get; set; }
        public string Components { get; set; }
        public int Classes { get; set; }
    }
}
