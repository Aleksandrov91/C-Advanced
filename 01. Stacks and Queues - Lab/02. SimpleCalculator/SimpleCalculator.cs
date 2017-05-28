using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculator
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var values = new Stack<string>(input.Reverse());

            while (values.Count > 1)
            {
                var firstOperand = int.Parse(values.Pop());
                var operand = values.Pop();
                var secondOperand = int.Parse(values.Pop());

                switch (operand)
                {
                    case "+":
                        values.Push((firstOperand + secondOperand).ToString());
                        break;
                    case "-":
                        values.Push((firstOperand - secondOperand).ToString());
                        break;
                }
            }

            Console.WriteLine(values.Pop());
        }
    }
}
