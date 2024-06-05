using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Skills
    {
        [Key]
        public int Skill_id { get; set; }
        public string Name { get; set; }
    }
}
