using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// This code uses a value from input and uses it to return a statement
        /// </summary>
        /// <param name="code">The secret code that the user will input</param>
        /// <returns>
        /// A statement that uses the input and calls it a secret
        /// </returns>
        /// <example>
        /// https://localhost:XX/api/q5/Secret -> "Shh.. the secret is 90"
        /// Request Body: "90"
        /// Content-Type: application/json
        /// </example>
        [HttpPost(template: "secret")]

        public string Secret([FromBody] string code)
        {
            string Message = "Shh..the secret is " + code.ToString();
            return Message;
        }
    }
}
