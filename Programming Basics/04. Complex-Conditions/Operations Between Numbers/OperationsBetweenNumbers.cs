using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Between_Numbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string deistvie = Console.ReadLine();

            if (deistvie == "+")
            {
                double sum = n1 + n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, deistvie, n2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, deistvie, n2, sum);
                }
            }
            else if (deistvie == "-")
            {
                double sum = n1 - n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, deistvie, n2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, deistvie, n2, sum);
                }
            }
            else if (deistvie == "*")
            {
                double sum = n1 * n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, deistvie, n2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, deistvie, n2, sum);
                }
            }
            else if (deistvie == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    double sum = n1 / n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, deistvie, n2, sum);
                }
            }
            else if (deistvie == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    double sum = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, deistvie, n2, sum);
                }
            }
        }
    }
}
