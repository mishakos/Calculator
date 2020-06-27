namespace Calculator.Services
{
    public class ResultViewModel
    {
        public decimal Data { get; set; }
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }

        public static ResultViewModel GenerateResult(decimal data)
        {
            return new ResultViewModel { Data = data };
        }

        public static ResultViewModel GenerateError(string errorMessage)
        {
            return new ResultViewModel { HasError = true, ErrorMessage = errorMessage };
        }
    }
}
