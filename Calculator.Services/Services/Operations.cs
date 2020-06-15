namespace Calculator.Services.Services
{
    public class Operations : IOperations
    {
        public decimal Division(decimal a, decimal b)
        {
            return a / b;
        }

        public decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
