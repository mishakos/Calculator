using Calculator.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    public class OperationsController : ControllerBase
    {
        private readonly ILogger<OperationsController> logger;

        public OperationsController(ILogger<OperationsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            CalcService.InitStandartOperations();
            return Ok(CalcService.operations.Select(p => new { key = p.Id, value = p.Title }));
        }

    }
}
