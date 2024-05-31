using System.ComponentModel.DataAnnotations;

namespace DnDCharacterCreator.Models
{
    public class Player
    {
        [Key]
        public int Player_id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
