using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// To get the input from URL showcase on the website
        /// </summary>
        /// <param name="name">The name of the user</param>
        /// <returns>
        /// It welcomes a user by their name
        /// </returns>
        /// <example>
        /// GET api/q2/greeting?name=Gary
        /// </example>
        /// <example>
        /// GET api/q2/greeting?name=Anslem
        /// </example>
        [HttpGet("greeting")]
        public string Greeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}
