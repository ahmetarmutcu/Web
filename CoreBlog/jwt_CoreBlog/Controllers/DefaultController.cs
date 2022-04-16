using jwt_CoreBlog.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwt_CoreBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("action")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet]
        public IActionResult Page1()
        {
            return Ok("Sayfa 1 için girişiniz başarılı");
        }
    }
}
