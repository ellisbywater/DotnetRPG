using System.Collections.Generic;
using System.Linq;
using Dotnet_Rpg.Models;
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
        private static Character knight = new Character();
        
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(knight);
        }
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character character)
        {
            _characters.Add(character);
            return Ok(_characters);
        }
    }
}