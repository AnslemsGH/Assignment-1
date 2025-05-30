using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// To get a specific date if today was Jan 1, 2000
        /// </summary>
        /// <param name="days">user input number of days</param>
        /// <returns>
        /// Returns a string representation of the current date (formatted yyyy-MM-dd), adjusted by days
        /// </returns>
        /// <example>
        /// GET https://localhost:XX/api/q7/timemachine?num=-1 -> 1999-12-31
        /// </example>
        [HttpGet(template: "timemachine")]
        public string Timemachine([FromQuery] int days)
        {
            DateTime thisday = new DateTime(2000, 01, 01);
            DateTime answer = thisday.AddDays(days);
            string pattern = "yyyy-MM-dd";
            return answer.ToString(pattern);
        }
    }
}
