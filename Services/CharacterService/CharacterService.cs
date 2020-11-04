using Dotnet_Rpg.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_Rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService

    {
        private static List<Character> _characters = new List<Character>
        {
            new Character {Name = "Aragon", Class = RpgClass.Warden},
            new Character(),
            new Character {Name = "Gandalf", Class = RpgClass.Mage}
        };
        public async Task<List<Character>> AddCharacter(Character character)
        {
            _characters.Add(character);
            return _characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return _characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return _characters.FirstOrDefault(c => c.Id == id);
        }
    }
}