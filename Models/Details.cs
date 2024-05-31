using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Details
    {
        [Key]
        public int Detail_id { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public string Image { get; set; }
    }
}
