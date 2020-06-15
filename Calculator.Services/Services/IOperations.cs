namespace Calculator.Services.Services
{
    public interface IOperations
    {
        decimal Multiplication(decimal a, decimal b);
        decimal Division(decimal a, decimal b);
        decimal Sum(decimal a, decimal b);
        decimal Subtraction(decimal a, decimal b);
    }
}
