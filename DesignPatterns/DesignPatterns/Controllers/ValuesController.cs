using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Business;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public double Post([FromBody] string value)
        {
            Client Client = new Client();

            double subtotal = 100, total = 0;

            if (Client.Resident)
            {
                total = subtotal * 0.9;
            }

            if (Client is Regular)
            {
                total = subtotal * 0.85;
            }

            return total;
        }
    }
}
