using Dotnet_Rpg.Data;
using Dotnet_Rpg.Dtos.User;
using Dotnet_Rpg.Models;
using Dotnet_Rpg.Models.Util;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dotnet_Rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository; 
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDTO user)
        {
            ServiceResponse<int> response = await _authRepository.Register(
                new User { Username = user.Username}, user.Password    
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO user)
        {
            ServiceResponse<string> response = await _authRepository.Login(
                user.Username, user.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}