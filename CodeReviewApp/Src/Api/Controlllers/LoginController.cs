using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodeReviewApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequestModel model)
        {
            // Aquí puedes implementar la lógica de autenticación y generación de tokens

            // Ejemplo de respuesta exitosa con un token
            var token = "your_generated_token";
            return Ok(new { Token = token });
        }
    }
}