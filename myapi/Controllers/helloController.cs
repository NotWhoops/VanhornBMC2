using Microsoft.AspNetCore.Mvc;

namespace API_Rehash.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("SayHello/{name}")]
        public string SayHello(string name)
        {
            return $"Hello {name}!";
        }
    }
}