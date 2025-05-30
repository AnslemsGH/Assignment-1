using System.Numerics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the area of a regular hexagon
        /// </summary>
        /// <param name="side">Side of the Hexagon</param>
        /// <returns>Returns the area of a regular hexagon with side length double {S}</returns>
        /// <example>
        /// GET http://localhost:xx/api/q6/hexagon?side=1 -> 2.598076211353315
        /// </example>
        [HttpGet(template: "hexagon")]

        public string Hexagon(decimal side)
        {
            decimal Calculation1 = (decimal)(3 * Math.Sqrt(3))/2;
            decimal Calculation2 = (decimal)Math.Pow((double)side, 2);
            decimal Calculation3 = Calculation1 * Calculation2;
            return Calculation3.ToString();
        }

    }
}
