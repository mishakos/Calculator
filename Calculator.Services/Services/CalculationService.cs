using Calculator.Services.Enums;
using Calculator.Services.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Services.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly IOperations operations;

        public CalculationService(IOperations operations)
        {
            this.operations = operations;
        }

        public Dictionary<int, string> GetOperationTypes()
        {
            return Enum.GetValues(typeof(OperationEnum))
                    .Cast<object>()
                    .ToDictionary(k => (int)k, v => ((Enum)v).ToString());
        }

        public decimal GetResult(InputDataViewModel model)
        {
            decimal result = 0m;

            if (model == null)
            {
                return result;
            }

            switch (model.FirstOperation)
            {
                case Enums.OperationEnum.Multiplication:
                    result = operations.Multiplication(model.FirstArgument, model.SecondArgument);
                    break;
                case Enums.OperationEnum.Division:
                    result = operations.Division(model.FirstArgument, model.SecondArgument);
                    break;
                case Enums.OperationEnum.Sum:
                    result = operations.Sum(model.FirstArgument, model.SecondArgument);
                    break;
                case Enums.OperationEnum.Subtraction:
                    result = operations.Subtraction(model.FirstArgument, model.SecondArgument);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
