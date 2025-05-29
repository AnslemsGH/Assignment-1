using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        [HttpPost("knockknock")]
        public string Get()
        {
            return "Who's there?";
        }
    }
}
