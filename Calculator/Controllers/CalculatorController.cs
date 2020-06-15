using Calculator.Services.Services;
using Calculator.Services.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Linq;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> logger;
        private readonly ICalculationService service;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculationService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpPost("calculateresult")]
        public IActionResult CalculateResult([FromBody]InputDataViewModel model)
        {
            return Ok(new { result = service.GetResult(model) });
        }

        [HttpGet("operationtypes")]
        public IActionResult GetOperationTypes()
        {
            return Ok(service.GetOperationTypes().ToList());
        }
    }
}
