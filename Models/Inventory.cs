using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Inventory
    {
        [Key]
        public int Character_id { get; set; }
        public int Platinum { get; set; }
        public int Gold { get; set; }
        public int Electrum { get; set; }
        public int Silver { get; set; }
        public int Copper { get; set; }
        public string Equipment { get; set; }
    }
}
