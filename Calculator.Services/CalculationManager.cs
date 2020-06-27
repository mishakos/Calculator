using System;

namespace Calculator.Services
{
    public static class CalculationManager
    {

        public static decimal Multiplication(decimal operand1, decimal operand2)
        {
            return operand1 * operand2;
        }

        public static decimal Division(decimal operand1, decimal operand2)
        {
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Can not divide by zero.");
            }
            return operand1 / operand2;
        }

        public static decimal Sum(decimal operand1, decimal operand2)
        {
            return operand1 + operand2;
        }

        public static decimal Substrat(decimal operand1, decimal operand2)
        {
            return operand1 - operand2;
        }
    }
}
