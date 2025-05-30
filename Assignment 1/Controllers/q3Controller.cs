using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// To get cube of a value mentioned in the url
        /// </summary>
        /// <param name="cube">The number for which the cube will be displayed</param>
        /// <returns>
        /// The cube of a value
        /// </returns>
        /// <example> api/q3/cube?cube=10 -> 1000</example>
        [HttpGet(template: "cube")]

     public string Cube(int cube)
        {
            int Cuboid = cube * cube * cube;
            return Cuboid.ToString();
        }
    }
}
