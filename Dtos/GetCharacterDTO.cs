using Dotnet_Rpg.Models;

namespace Dotnet_Rpg.Dtos.Character
{

    public class GetCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Stamina { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Willpower { get; set; } = 10;
        public int Cunning { get; set; } = 10;
        public int Magic { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }

}