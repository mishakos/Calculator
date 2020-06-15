using Calculator.Services.ViewModels;
using System.Collections.Generic;

namespace Calculator.Services.Services
{
    public interface ICalculationService
    {
        decimal GetResult(InputDataViewModel model);
        Dictionary<int, string> GetOperationTypes();
    }
}