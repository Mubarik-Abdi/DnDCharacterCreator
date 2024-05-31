using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Skills
    {
        [Key]
        public int Skill_id { get; set; }
        public int Acrobatics { get; set; }
        public int Animal_handling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persuasion { get; set; }
        public int Religion { get; set; }
        public int Slight_of_hand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }
    }
}
