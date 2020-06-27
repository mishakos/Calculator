using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Services
{
    public static class CalcService
    {
        public static List<OperationViewModel> operations = new List<OperationViewModel>();

        public static ResultViewModel GetTwoArgumentResult(LinkedList<string> formula)
        {
            try
            {
                if (formula.Count > 3)
                {
                    throw new ArgumentException("Formula have to contain only 3 elements.");
                }

                var firstOperand = formula.First;
                var secondOperand = formula.Last;
                var operation = firstOperand.Next.Value;
                if (decimal.TryParse(firstOperand.Value, out decimal operand1) && decimal.TryParse(secondOperand.Value, out decimal operand2))
                {
                    var selectedOperation = operations.Where(p => p.Id.ToString() == operation).FirstOrDefault();
                    if (selectedOperation == null)
                    {
                        throw new NotImplementedException("This operation not implemented yet.");
                    }
                    return ResultViewModel.GenerateResult(selectedOperation.Action(operand1, operand2));
                }
                else
                {
                    throw new ArgumentException("Operands are not numeric.");
                }
            }
            catch (Exception ex)
            {
                return ResultViewModel.GenerateError(ex.Message);
            }

        }

        public static void InitStandartOperations()
        {
            if (operations.Count == 0)
            {
                operations.Add(new OperationViewModel()
                {
                    Id = 1,
                    Title = "+",
                    Action = CalculationManager.Sum
                });
                operations.Add(new OperationViewModel()
                {
                    Id = 2,
                    Title = "-",
                    Action = CalculationManager.Substrat
                });
                operations.Add(new OperationViewModel()
                {
                    Id = 3,
                    Title = "*",
                    Action = CalculationManager.Multiplication
                });
                operations.Add(new OperationViewModel()
                {
                    Id = 4,
                    Title = "/",
                    Action = CalculationManager.Division
                });
            }
        }
    }
}
