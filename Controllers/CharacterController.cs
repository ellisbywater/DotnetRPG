using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_Rpg.Models;
using Dotnet_Rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> _characters = new List<Character>
        {
            new Character {Name = "Aragon", Class = RpgClass.Warden},
            new Character(),
            new Character {Name = "Gandalf", Class = RpgClass.Mage}
        };

        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        private static Character knight = new Character();
        

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }
    }
}