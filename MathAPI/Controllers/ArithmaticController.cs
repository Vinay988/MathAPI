using Microsoft.AspNetCore.Mvc;

namespace MathAPI.Controllers
{
    [ApiController]
    [Route("api/arithmatic")]
    public class ArithmaticController : Controller
    {
        [HttpGet]
        [Route("add")]
        public IActionResult Add(int a, int b)
        {
            int result = a + b;
            return Ok(result);
        }
    }
}
