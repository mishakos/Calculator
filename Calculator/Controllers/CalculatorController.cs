using Calculator.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("twoargumentresult")]
        public IActionResult GetResult(string operand1, int operation, string operand2)
        {
            var formula = new LinkedList<string>();
            formula.AddLast(operand1);
            formula.AddLast(operation.ToString());
            formula.AddLast(operand2);
            return Ok(CalcService.GetTwoArgumentResult(formula));
        }
    }
}
