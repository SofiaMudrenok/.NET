using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace module.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moduleController : ControllerBase
    {
        [HttpGet("zavd1")]
        public async Task<ActionResult<Tuple<int, int>>> Get(int a, int b)
        {

            if (a < 0 || b < 0)
            {
                return BadRequest(400);
            }
            int area = a * b;

            int perimeter = 2 * (a + b);

            return Ok(Tuple.Create(area, perimeter));
        }
    

    [HttpGet("zavd2")]
    public async Task<ActionResult<double>> Get(float a,float x, int n)
    {
        if (n < 1)
        {
            return BadRequest(400);
        }
        double Sum =Math.Pow (x+a,2.0);
        for (int i = 0; i < n; i++)
        {
            Sum +=  Math.Pow(a + Sum, 2.0);
        }
            Sum += a;
        return Ok(Sum);
    }
}}