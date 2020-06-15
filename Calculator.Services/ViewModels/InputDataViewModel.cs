using Calculator.Services.Enums;

namespace Calculator.Services.ViewModels
{
    public class InputDataViewModel
    {
        public decimal FirstArgument { get; set; }
        public OperationEnum FirstOperation { get; set; }
        public decimal SecondArgument { get; set; }
    }
}
