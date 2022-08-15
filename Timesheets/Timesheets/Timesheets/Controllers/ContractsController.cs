using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[api/contracts]")]
    public class ContractsController : ControllerBase
    {
        private readonly ILogger<ContractsController> _logger;

        public ContractsController(ILogger<ContractsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
