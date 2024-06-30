using BalzorRenderModes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BalzorRenderModes.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CounterController : ControllerBase
    {
        private readonly ICounterService counterService;

        public CounterController(ICounterService counterService)
        {
            this.counterService = counterService;
        }

        [HttpGet]
        public IActionResult Increment(int counter)
        {
            try
            {
                int result = counterService.Increment(counter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request."); // Returns a 500 Internal Server Error response.
            }
        }
    }
}
