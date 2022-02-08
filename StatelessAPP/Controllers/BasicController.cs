using Microsoft.AspNetCore.Mvc;

namespace StatelessAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        private readonly IConfiguration _config;

        public BasicController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("stateless-operation")]
        public IActionResult DoStatelessOperation()
        {
            var nodeId = _config["NodeId"];

            return Ok(nodeId);
        }
    }
}
