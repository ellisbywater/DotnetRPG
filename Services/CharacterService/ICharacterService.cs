using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_Rpg.Models;
using Dotnet_Rpg.Models.Util;

namespace Dotnet_Rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character character);
    }
}