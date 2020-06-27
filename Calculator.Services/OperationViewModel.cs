using System;

namespace Calculator.Services
{
    public class OperationViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Func<decimal, decimal, decimal> Action { get; set; }

    }
}
