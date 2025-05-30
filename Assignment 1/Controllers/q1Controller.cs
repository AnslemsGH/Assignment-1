using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// A welcome message
        /// </summary>
        /// <returns>
        /// Welcomes the user
        /// </returns>
        /// <example>
        /// https://localhost:xx/api/q1/welcome -> Welcome to 5125!
        /// </example>
        [HttpGet(template: "welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
