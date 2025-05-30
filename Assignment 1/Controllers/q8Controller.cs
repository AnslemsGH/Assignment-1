using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        /// <summary>
        /// To derive the final cost of the plushies purchased.
        /// </summary>
        /// <param name="small">the quantity of small plushie purchased</param>
        /// <param name="large">the quantity of large plushie purchased</param>
        /// <returns>A message showing entire calculation of small, large and tax along with total</returns>
        /// <example>
        /// https://localhost:xx/api/q8/squashfellow -> "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"
        /// Request Body: small=1&large=1
        /// Content-Type: application/x-www-form-urlencoded
        /// </example>


        [HttpPost(template: "squashfellow")]

        public string squashfellow([FromForm]int small, [FromForm]int large)
        {
            decimal smallcost = 25.50m;
            decimal largecost = 40.50m;
            decimal smallcal = small * smallcost;
            decimal largecal = large * largecost;
            decimal subtotal = smallcal + largecal;
            decimal tax = Math.Round(subtotal * 0.13m,2);
            decimal total = subtotal + tax;
            string Message = $"{small} Small @ ${smallcost} = ${smallcal}; {large} Large @ ${largecost} = ${largecal}; Subtotal = ${subtotal}; Tax = ${tax} HST; Total = ${total}";
            return Message;
        }
    }
}
