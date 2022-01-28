using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {
        public IActionResult Get()
        {
            var channels = new String[] {".NetCore", "ReactJs", "Angular"};
            return Ok(channels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(".NetCore");
        }
    }
}