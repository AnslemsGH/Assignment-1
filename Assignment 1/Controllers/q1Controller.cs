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
        /// 
        /// </example>
        [HttpGet("welcome")]
        public string Get()
        {
            return "Welcome to 5125!";
        }
    }
}
