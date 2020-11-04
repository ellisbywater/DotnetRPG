using Dotnet_Rpg.Models;
using Dotnet_Rpg.Models.Util;
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

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character character)
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            _characters.Add(character);
            serviceResponse.Data = _characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = _characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = _characters.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
        }
    }
}