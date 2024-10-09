using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(IFormFile file)
        {
            var description = $"File: {file.FileName}, Size: { file.Length}";

            //Processar a imagem, guardar local, no bd, container, no s3...

            return Ok(description);
        }
    }
}