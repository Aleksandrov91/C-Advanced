using System.ComponentModel.DataAnnotations;

namespace Calculator_CSharp.Models
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }

        [RegularExpression("[-+]?([0-9]*\\.[0-9]+|[0-9]+)", ErrorMessage = "The field must be real number")]
        public decimal LeftOperand { get; set; }

        [RegularExpression("[-+]?([0-9]*\\.[0-9]+|[0-9]+)", ErrorMessage = "The field must be real number")]
        public decimal RightOperand { get; set; }

        public string Operator { get; set; }

        public decimal Result { get; set; }
    }
}