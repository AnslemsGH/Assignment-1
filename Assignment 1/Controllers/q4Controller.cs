using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// It begins responding to the knock knock joke
        /// </summary>
        /// <returns>
        /// response to the first line of the knockknock joke
        /// </returns>
        /// <example>
        ///  api/q4/knockknock -> "Who's there?"
        ///  Request Body: None
        /// </example>
        [HttpPost(template: "knockknock")]
        public string Knockknock()
        {
            return "Who's there?";
        }
    }
}
