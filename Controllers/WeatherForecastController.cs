using Microsoft.AspNetCore.Mvc;
using MyWebApi.Test;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult GetTest()
        {
            var common = new Class1();
            return Ok(common.GetMessage());
        }
    }
}
