using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_Rpg.Dtos;
using Dotnet_Rpg.Dtos.Character;
using Dotnet_Rpg.Models;
using Dotnet_Rpg.Models.Util;

namespace Dotnet_Rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters(int userId);
        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
        Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updateCharacter);
        Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id);
    }
}