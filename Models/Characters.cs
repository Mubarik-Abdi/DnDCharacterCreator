using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Characters
    {
        [Key]
        public int Character_id { get; set; }
        public long User_id { get; set; }
        public int Race { get; set; }
        public int Class { get; set; }
        public int Level { get; set; }
        public string Alignment { get; set; }
        public int Hit_point_maximum { get; set; }
        public int Hit_point_current { get; set; }
        public int Background { get; set; }
        public int EXP { get; set; }
        public int Inventory { get; set; }
        public int Stats { get; set; }
        public int Description { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Languages { get; set; }
        public int Skills { get; set; }
        public int Proficiency_bonus { get; set; }
        public string Hit_dice_total { get; set; }
    }
}
